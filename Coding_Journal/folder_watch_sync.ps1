# Define paths
$sourceFolder = "C:\Users\user\iCloudDrive\Noteful"
$batFile = "C:\Users\user\Coding_Journal\sync_notes.bat"
$backupRootFolder = "C:\Users\user\Coding_Journal\Concepts_Backups"
$logFile = "C:\Users\user\Coding_Journal\sync_log.txt"
$logBackupFolder = "C:\Users\user\Coding_Journal\Log_Backups"

# Maximum log file size (in bytes) before rotating (e.g., 1MB = 1048576 bytes)
$maxLogSize = 1048576 

# Number of days to keep log backups
$logRetentionDays = 30 

# Function to write to the log file
function Write-Log {
    param ([string]$message)
    
    # Check log file size before writing
    if (Test-Path $logFile) {
        $logSize = (Get-Item $logFile).Length
        if ($logSize -gt $maxLogSize) {
            Rotate-Log
        }
    }

    Add-Content -Path $logFile -Value "$(Get-Date): $message"
}

# Function to rotate the log file
function Rotate-Log {
    if (!(Test-Path $logBackupFolder)) {
        New-Item -ItemType Directory -Path $logBackupFolder | Out-Null
    }

    # Create a timestamped backup of the log file
    $timestamp = Get-Date -Format "yyyy-MM-dd_HH-mm-ss"
    $backupLogFile = Join-Path -Path $logBackupFolder -ChildPath "sync_log_$timestamp.txt"

    Move-Item -Path $logFile -Destination $backupLogFile
    Write-Output "Log file rotated to: $backupLogFile"
    Write-Log "Log file rotated. New log started."

    # Run cleanup after rotating logs
    Cleanup-OldLogs
}

# Function to clean up old log files
function Cleanup-OldLogs {
    Write-Log "Running log cleanup. Deleting logs older than $logRetentionDays days..."
    $oldLogs = Get-ChildItem -Path $logBackupFolder -Filter "sync_log_*.txt" | Where-Object { $_.LastWriteTime -lt (Get-Date).AddDays(-$logRetentionDays) }

    foreach ($log in $oldLogs) {
        try {
            Remove-Item -Path $log.FullName -Force
            Write-Log "Deleted old log file: $($log.FullName)"
        } catch {
            Write-Log "ERROR: Failed to delete old log file: $($log.FullName) - $_"
        }
    }
}

# Ensure required folders exist
if (!(Test-Path $backupRootFolder)) { New-Item -ItemType Directory -Path $backupRootFolder | Out-Null }
if (!(Test-Path $logBackupFolder)) { New-Item -ItemType Directory -Path $logBackupFolder | Out-Null }

Write-Log "Polling folder: $sourceFolder"
Write-Log "Sync script started. Monitoring for changes..."
Write-Output "Press Ctrl+C to stop the script."

# Get initial state of the folder
$initialSnapshot = Get-ChildItem -Recurse -Path $sourceFolder -File | Select-Object FullName, LastWriteTime

# Continuous loop to check for changes
while ($true) {
    Start-Sleep -Seconds 10

    # Get the current state of the folder
    $currentSnapshot = Get-ChildItem -Recurse -Path $sourceFolder -File | Select-Object FullName, LastWriteTime
    
    # Compare with the initial snapshot
    $changes = Compare-Object -ReferenceObject $initialSnapshot -DifferenceObject $currentSnapshot -Property FullName, LastWriteTime
    
    if ($changes) {
        Write-Log "Change detected. Creating backup and running sync..."

        # Create a timestamped backup folder
        $timestamp = Get-Date -Format "yyyy-MM-dd_HH-mm-ss"
        $backupFolder = Join-Path -Path $backupRootFolder -ChildPath $timestamp
        
        try {
            New-Item -ItemType Directory -Path $backupFolder | Out-Null
            Write-Log "Created backup folder: $backupFolder"

            Copy-Item -Path "$sourceFolder\*" -Destination $backupFolder -Recurse -Force
            Write-Log "Backup completed successfully to: $backupFolder"

            Start-Process -FilePath $batFile -NoNewWindow -Wait
            Write-Log "Sync completed successfully."
        } catch {
            Write-Log "ERROR: Backup or sync failed with error: $_"
        }

        $initialSnapshot = $currentSnapshot
    }
}
