# HEXCHAT SBCLIENT

## Why did I build this? 
Mirc has SBclient, but I hate using Mirc. I built a basic searchbot client for Hexchat,
or really any IRC Client that can download from 


## How it works 

### User Side 
0. Launch the application using HexchatSBClient.exe
1. Set Your Download Folder - Defaults to the User Download Folder - Just a text box for now because I have been lazy 
2. Hit the start button 
3. Filter Your Search results 
4. Copy Paste from the table into your IRC client
5. Recieve files 

### What the program does 

1. It scans your downloads folder for files following a naming convention of SearchBot_results_for_*.zip. 
2.  it extracts all of the .txt results files. to the same folder 
3.  it Searches for the SearchBot_results_for_*.txt files and loads them into memory 
4.  If you enter something into the search box, it filters the results table to only show items containing the string you searched 
5.  From there you can copy-paste into your irc client to download the files.