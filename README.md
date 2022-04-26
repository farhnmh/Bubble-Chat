# Bubble Chat JSON
(Author) 4210181002 Farhan Muhammad

(Course) Praktikum Desain Game Multiplayer Online

### Result File
![Result File](/BubbleChat.gif)

### Flow Program
![FlowProgram](https://user-images.githubusercontent.com/57122816/165290118-7810cf93-33ac-4e57-991b-8bd429008798.png)

### Code Description
1. ([Request Data Code](BubbleChat/Assets/Scripts/RequestData.cs)) First, use UnityWebRequest as a plugin to make a request to get data from the website and use SimpleJSON to parse the obtained data

![image](https://user-images.githubusercontent.com/57122816/165290202-4ee8ced9-9259-4414-b5fd-4beefb5a1b59.png)

2. ([Personal Data Code](BubbleChat/Assets/Scripts/PersonalData.cs)) Then, create a new struct object, which will store the data that has been obtained (id, name, avatar and email)

![image](https://user-images.githubusercontent.com/57122816/165290218-9ccff786-7339-408d-982c-c9f51084e350.png)

3. ([Writing Animation Code](BubbleChat/Assets/Scripts/WritingAnimation.cs)) Display data that has been stored in an array of structs, and run the animation

![image](https://user-images.githubusercontent.com/57122816/165290228-33cf583e-d89f-42e5-959a-ca478b621ca9.png)
