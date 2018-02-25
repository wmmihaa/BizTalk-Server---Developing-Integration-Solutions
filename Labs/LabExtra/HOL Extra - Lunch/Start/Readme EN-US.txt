In your start folder you have two files.
Food.xml/Mat.xml and Restaurant.xsd/Restaurang.xsd

The goal is to send a message in Restaurant format to an http endpoint supplied by your instructor.

Good luck!





Here are some hints to get you started:

Use Food.xml to generate a schema using Visual Studio, a BizTalk project and Add - Add Generated Items... - Generate Schema - from Well-known XML.

Create a map from Food to Restaurant.

Sign and deploy.

Create a one way static receive with an xml pipeline that can pickup the food file from a folder and configure it with the map.

Create a one way static basicHttp send port and configure it to send to the address supplied by your instructor. Be sure to create a subscription, either connected to the messagetype of food or the receive port that picks it up.

Enable/Start the ports.

Send the file.
