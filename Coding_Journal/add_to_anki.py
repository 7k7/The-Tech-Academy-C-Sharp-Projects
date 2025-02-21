import os
import re
import requests
import json

# ✅ Define Paths
concepts_folder = "C:/Users/user/Documents/GitHub/The-Tech-Academy-C-Sharp-Projects/Coding_Journal/Concepts"

# ✅ AnkiConnect API URL
anki_connect_url = "http://localhost:8765"

# ✅ Define the Anki deck name
anki_deck = "C# Review Schedule"

# ✅ Function to add a new note to Anki
def add_concept_to_anki(concept_title, front_content, back_content, md_filename):
    note = {
        "action": "addNote",
        "version": 6,
        "params": {
            "note": {
                "deckName": anki_deck,
                "modelName": "Basic",
                "fields": {
                    "Front": front_content,
                    "Back": back_content
                },
                "tags": [md_filename.replace(".md", "")]
            }
        }
    }
    response = requests.post(anki_connect_url, json=note).json()
    if response.get("error"):
        print(f"❌ Failed to add: {concept_title} - {response['error']}")
    else:
        print(f"✅ Added to Anki: {concept_title}")

# ✅ Function to extract content for each Concept Title from Markdown
def extract_concept_data(md_filepath):
    with open(md_filepath, "r", encoding="utf-8") as file:
        content = file.read()

    concepts = []
    concept_blocks = re.split(r"(## 🔹 .+)", content)[1:]  # Split by Concept Title

    for i in range(0, len(concept_blocks), 2):
        concept_title = concept_blocks[i].strip("## 🔹").strip()
        concept_body = concept_blocks[i + 1] if i + 1 < len(concept_blocks) else ""

        # ✅ Extract Active Recall Questions
        active_recall_match = re.search(r"🔄 \*\*Active Recall Questions:\*\*\n(.*?)(?:\n\n|---|\Z)", concept_body, re.DOTALL)
        active_recall = active_recall_match.group(1).strip() if active_recall_match else "No Active Recall Questions found."

        # ✅ Extract Key Takeaways
        key_takeaways_match = re.search(r"📌 \*\*Key Takeaways:\*\*\n(.*?)(?:\n\n|---|\Z)", concept_body, re.DOTALL)
        key_takeaways = key_takeaways_match.group(1).strip() if key_takeaways_match else "No Key Takeaways available."

        # ✅ Extract Code Example
        code_match = re.search(r"👨‍💻 \*\*Code Example:\*\*\n```csharp\n(.*?)\n```", concept_body, re.DOTALL)
        code_example = code_match.group(1).strip() if code_match else "No Code Example available."

        # ✅ Ensure formatted HTML in Anki
        show_code_button = (
            f"<details><summary>👨‍💻 <b>Show Code</b></summary>\n"
            f"<pre><code>{code_example}</code></pre>\n"
            f"</details>"
            if code_example != "No Code Example available." else "No code example available."
        )

        # ✅ Create Anki Card Content
        front_content = f"## 🔹 {concept_title}<br><br>" \
                        f"🔄 <b>Active Recall Questions:</b><br><br>" \
                        f"{active_recall.replace('\n', '<br>')}"

        back_content = f"📌 <b>Key Takeaways:</b><br><br>" \
                       f"{key_takeaways.replace('\n', '<br>')}<br><br>" \
                       f"{show_code_button}"

        concepts.append((concept_title, front_content, back_content))
    
    return concepts

# ✅ Step 1: Retrieve ALL Notes in the Deck
find_existing_query = {
    "action": "findNotes",
    "version": 6,
    "params": {
        "query": f"deck:{anki_deck}"
    }
}
response = requests.post(anki_connect_url, json=find_existing_query).json()
all_notes = response.get("result", [])

# ✅ Step 2: Fetch Full Note Details
notes_info_query = {
    "action": "notesInfo",
    "version": 6,
    "params": {"notes": all_notes}
}
notes_info = requests.post(anki_connect_url, json=notes_info_query).json().get("result", [])

# ✅ Step 3: Store Existing Notes by Title
existing_notes_map = {}

for note in notes_info:
    note_id = note["noteId"]
    front_text = note["fields"]["Front"]["value"].strip().split("<br>")[0].strip()
    
    existing_notes_map[front_text] = note_id

# ✅ Step 4: Scan Concepts Folder and Update Anki
for filename in os.listdir(concepts_folder):
    if filename.endswith(".md"):
        md_filepath = os.path.join(concepts_folder, filename)
        concepts_data = extract_concept_data(md_filepath)

        for concept_title, front_content, back_content in concepts_data:
            print(f"🔍 Checking for existing note: '{concept_title}'")

            # ✅ Step 5: Check if Concept Exists and Delete Before Updating
            if concept_title in existing_notes_map:
                note_id = existing_notes_map[concept_title]

                print(f"🛑 Found existing note for '{concept_title}', deleting old version...")
                delete_query = {
                    "action": "deleteNotes",
                    "version": 6,
                    "params": {"notes": [note_id]}
                }
                delete_response = requests.post(anki_connect_url, json=delete_query).json()

                if delete_response.get("error"):
                    print(f"❌ Deletion failed: {delete_response['error']}")
                else:
                    print(f"🗑️ Successfully deleted old note for: {concept_title}")

            # ✅ Step 6: Add the Updated Concept
            add_concept_to_anki(concept_title, front_content, back_content, filename)
