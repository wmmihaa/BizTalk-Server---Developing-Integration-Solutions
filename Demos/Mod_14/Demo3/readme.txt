Börja med att byta lösenord för service bus:

1. Gå till https://a372wabs-sb.accesscontrol.windows.net/
2. Öppna serviceaccount under Service identities
3. Klicka Symmetric Key -> Show key -> Generate
4. Kopiera nyckeln och gå tillbaka till Password och klistra in nyckeln
5. Gå till https://a372wabs.accesscontrol.windows.net/
6. Sätt samma värde för Symetric Key och password för serviceaccount
7. Dela ut den nya nyckeln till alla deltagare



1. Open VS with elevated privilages! Open the Demo3 project
2. Click the designer area point to the BizTalk Services URI. Make the point of the namespace(a372wabs).
3. Drag a One-way bridge call it SendMessage, and 2 queues, call them "Jerry" and "George" to the itinerary
4. Expand the Itinerary and open the jerry.config
5. Set the transportClientEndpointBehavior:
   <sharedSecret issuerName="serviceaccount" issuerSecret="[TODAYS KEY]" />
6. In the client endpoint(s) set the address to "sb://a372wabs.servicebus.windows.net/Jerry"
8. Repeat step 5 and 6 for George
9. Add a new schema, and add a "To" attribute and Copy the xPath to the "To" attribute
10. Open the One-way bridge
11. Click the enrich stage and Property Definitions in the property window
	Type: Xpath
	Identifier: Paste the xpath
	MessageType: Select the schema
	Property Name: "receiver"
	Datatype: string
12. Go back to the itinerary and add a connection to "Jerry", click the Filter Conditions and set it to "receiver='Jerry'"
13. Repeat step 12 for the Geeorge queue
14. Click the SendMessage Bridge and copy the Runtime URI
14. Start the MessageSender App with the following parameters:
	FilePath: demomsg.xml
	Uri: paste the Runtime address

	
