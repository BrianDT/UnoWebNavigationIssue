# UnoWebNavigationIssue
Lock on web page navigation from WASM app

Current bahaviour
In WASM when navigating to an external web page either programmatically or via a hyperlink the app becomes frozen and will not respond to further inputs. Sometimes after a new build the navigation will work twice but not more than that.

This does not happen in Windows, Android or iOS

Expected behaviour
When closing the web page navigate to the app should be responsive to user input

Reported as
Uno issue #11871