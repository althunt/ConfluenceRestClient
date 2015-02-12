# ConfluenceRestClient
.Net client to be able to get and update confluence pages

The reason I need to create this client, was because I need an easy way to get and update pages in Confluence. But even more than that, I wanted to update Macro content such as Uml diagrams and Charts.

To run the console test app, download the latest version of confluence and install the trial version. Create your first test page, then find the page id of the page - just click on edit, you can see the id in the url of your browser.

Then to update the page you can call the code like this :

//This will get the page from confluence
Page page = new Page("http://localhost:8090", 557060);

//You can update the title
page.title = "Some new title"

//You can add append your own content to the existing page
page.body.storage.value += "<b>Some new appended content</b>";

//To update a macro's data, such as a chart :
page.body.storage.UpdateMacroContent("myChart", "<table><tr><th>Hour</th><th>error</th></tr><tr><td>5</td><td>15</td></tr></table>");

//To push your changes back to the Confluence
page.Update();

You might get a 500 error that looks like you didnt specify a valid page Id, you probably need to put your confluence username and password into the app.config file before you run it.
