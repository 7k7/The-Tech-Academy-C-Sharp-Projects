# HTTP

**Overview**
These methods are specific to the WEB

---
## 🔹 HTTP Key Concepts
It is a client/server system. It is stateless.

📌 **Key Takeaways:**
- HTTP is a client/server system.
- HTTP is stateless = does keep track of operations; only processes requests and has recollection of previous requests
- Client = broswer
- Server = web server
- `HTTP Messages` allow a client to communicate requests to a server to retrieve resources from it.
- Two types of `HTTP Messages`: Request and Response messages
- The format of any of the two types of `HTTP Messages` is the same and as follows:
Start line, headers, and body (optional)
- `start line` defines what resource is in question
- `headers` are modifications to the `HTTP Message` like what language is being used, or what format is the resource to be delivered in.
- `body` is optional and is the data that is needed to accomplish the overall messsage
- The `HTTP method or verb` defines what do with the resource 
- The `HTTP verb` is found in the `start line`
- `HTTP Response Message` will contain the result code. 200 is ok, 404 means not exist
- The `result code` is found in the `start line` in a `Reponse message`
- The resource requested is found in the `body` of a `Reponse message`
- there are 4 `HTTP verbs`: GET, POST, PUT, DELETE
- The `POST, PUT, DELETE HTTP verbs` make this client/server system `stateful` by allowing `HTTP Requests` to change the state of data of an app

🔄 **Active Recall Questions:**
1. What is hTTP?
2. What does it mean that HTTP is stateless?
3. What is an example of a `client`?
4. What is an example of a `server`?
5. What is the purpose of `HTTP Messages`?
6. What are the two types of `HTTP MESSAGE`?
7. What is the general format of a `HTTP Message`?
8. What does a `start line` define in a `HTTP Message`?
9. What are `Headers` used for in `HTTP Messages`?
10. When is `Body` of a `HTTP Message` used for?
11. What does an `HTTP method` do?
12. In a `HTTP Request`, where is the `HTTP Method` found in?
13. What is the `result code`? Where is it found? What are the different types?
14. Where is the `resource` found in a `HTTP Response`?
15. What are the 4 `HTTP verbs`?
16. What makes the HTTP system `STATEFUL`?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 GET REQUEST
`Get` is a method in a `HTTP request` that only retrieves a file or data:

📌 **Key Takeaways:**
- `GET` requests is an HTTP request for retieving data only
- EXAMPLE: accessing a website executes a GET request to that website's server which will then return the specific files of that website to your web browser.

🔄 **Active Recall Questions:**
1. What does a GET request do?
2. What type of HTTP request is sent when retrieving a website?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 POST REQUEST
`POST` is a method in a `HTTP request` that modifies something in a database

📌 **Key Takeaways:**
- `POST` requests modify data in a database
- They are risky as they change existing data
- EXAMPLE: submiting of form in a website to sign up for their newsletter. All your data is stored into their database via a POST method

🔄 **Active Recall Questions:**
1. What does a POST request do?
2. What type of HTTP request is sent to website when you submit a form?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 IP ADDRESS
Detemines how to format data and transmit data between a newtork of computers in the internet

📌 **Key Takeaways:**
- `IP` stands for Internet Protocol
- `IP` is the highest-level protocol for describing how to format and transmit data among a network of computers in the internet
- `IP address` is a numbered address of a computer that identifies it on a network
- Every computer has an `IP address` unique to it.

🔄 **Active Recall Questions:**
1. What does IP stand for?
2. What is IP?
3. What is an IP address?
4. What is assigned an IP address?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 PORT in computers
There are a few diff usages of the word `port` in computers:

📌 **Key Takeaways:**
- A physical location on a computer to connect an i/o device
- Ports to transmit and receive data from other computers in  connected network
- these 'ports` are uniquely-named connections to send or receive data.

🔄 **Active Recall Questions:**
1. A port can be a ___ location?
2. A port is also a ____ to send or receive data.
3. Ports, non-physical type, are unique?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Localhost
shorthand for your computer's ip address

📌 **Key Takeaways:**
- `localhost` is the shorthand way of typing your computer's ip address
- `localhost` is your computer's web-facing home directory when you type it in the web broswer search bar
- locally run apps use localhost

🔄 **Active Recall Questions:**
1. What is localhost?
2. What does localhost reference to?
3. To run apps locally, you would use what?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Scaffolding
The process of an IDE in using a built-in template to create the basic framwork of your app

📌 **Key Takeaways:**
- `scaffolding` is the process of building the basic framework of your app 
- IDEs have built-in templates for different types of apps that are used when scaffolding
- The purpose is to quickly get an app up and running and to focus on just the specific features your app needs

🔄 **Active Recall Questions:**
1. What is scaffolding?
2. What does scaffolding use from IDEs in its process?
3. What is the purpose of scaffolding?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---