# ConfluenceRestClient
.Net client to be able to get and update confluence pages

Was a lot harder than I expected to be able to update pages in confluence. Hence the client to make it easier.

To run it, download the latest version of confluence and install the trial version. Create your test page, then find the page id of the page, once you click on edit, you can see the id in the url of your browser.

Then to update the page you can call the code like this :

Page page = new Page("http://localhost:8090", 557060);
page.title = "Some new title"
page.body.storage.value += "<p>Some new appended content</p>";
page.Update();

You might get a 500 error that looks like you didnt specify a valid page Id, you probably need to put your confluence username and password into the app.config file before you run it.
