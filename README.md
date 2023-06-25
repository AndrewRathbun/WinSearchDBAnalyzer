# WinSearchDBAnalyzer

This project is a revival of moaistory's [WinSearchDBAnalyzer](https://github.com/moaistory/WinSearchDBAnalyzer), further detailed [here](http://moaistory.blogspot.com/2018/10/winsearchdbanalyzer.html)

According to the original README, this tool can parse normal records and recover deleted records in Windows.edb. This file is related to Windows Search and can contain many interesting forensic artifacts. 

## Improvements

The original project was .NET 4, which is long past the end of its life. It has been updated to .NET 4.8, and all dependencies/packages have been updated to their latest version. Otherwise, very little code has been modified. Ideally, a CLI project would be created from this application's codebase to output to CSV, but that's a stretch goal at this point. 

## Features

 - Can recover deleted records
 - Works well on Windows 10+
 - Can extract and analyze Windows.edb from a live system
 - Regardless of the status of the file, WinSearchDBAnalyzer can parse any Windows.ebd file (clean or dirty)
 - WinSearchDBAnalyzer shows more information than the other tools (File categorization by extension, file hierarchy, file contents)
 - WinSearchDBAnalyzer can apply to UTC time

## What data exists in Windows.edb?

 - Outlook Mail Data (Time, Contents)
 - OneNote
 - Internet History (URLs, last visit time)
 - LNK
 - Network Drive (When adding offline)
 - Favorites
 - File, Folder Information (Time, Contents(2KB), Path...)
 - Activity History (Recently used programs, Windows 10 Timeline)

## Tips

 - If you want to see URLs that users visited, Search for: `http://` or `https://``
 - If you want to see internet queries, Search for: `q=` or `query=``
 - If you want to see the record for a certain time, Search for: `2023-02-`
 - If you want to see all the records, just select `ALL`
 - When recovering deleted records, be sure to check `Unknown`
 
 ## Issues/Feedback
 
 If you find any issues with the program, please let me know, and I'll do my best to fix it! I'm still learning C#, but basic maintenance to get this tool caught up to modern .NET was something the DFIR community needed done.
 
 ## Special Thanks
 
 Thank you to moaistory for creating this tool in the first place. I take zero credit for anything they've done and didn't want the project to fade into obscurity. There are not enough tools to parse this artifact, so this must be done!
 
