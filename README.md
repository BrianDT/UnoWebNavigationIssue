# UnoWebNavigationIssue
Lock on web page navigation from WASM app

Current bahaviour
In WASM when navigating to an external web page either programmatically or via a hyperlink the app becomes frozen and will not respond to further inputs. Sometimes after a new build the navigation will work twice but not more than that.

This does not happen in Windows, Android or iOS

Expected behaviour
After closing the web page navigated to, the app should be responsive to user input

Steps to reproduce
This app has one button and one hyperlink, navigate by either, close the web page navigated to and try and navigate again.

Reported as
Uno issue #11871

Updated to Uno 5.2.175
Confirmed Resolved
