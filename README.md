

``` __          ___  __ _   _____                           _             
 \ \        / (_)/ _(_) |_   _|                         | |            
  \ \  /\  / / _| |_ _    | |  _ __  ___ _ __   ___  ___| |_ ___  _ __ 
   \ \/  \/ / | |  _| |   | | | '_ \/ __| '_ \ / _ \/ __| __/ _ \| '__|
    \  /\  /  | | | | |  _| |_| | | \__ | |_) |  __| (__| || (_) | |   
     \/  \/   |_|_| |_| |_____|_| |_|___| .__/ \___|\___|\__\___/|_|   
                                        | |                            
                                        |_|                            
```
# Wifi-Inspector
Easy tool which check automatically for memorized networks and their passwords on your windows computer without having administrative privileges.
Find wifi passwords saved in your computer by clicking only 3 times!
## Features

This is a very simple tool made to show how many netowrks are currently saved on your computer showing also their password in clear format. Only few kbs of app! All happens automatically but you can check manually in order to have the same result by typing in cmd only 2 commands!


These are :

```
netsh wlan show profiles
```

and then 

```
netsh wlan show profiles name_of_your_ssid key=clear
```

That's all!

Anyway after a scan with wifi inspector you can save all results in a txt file.

### Demonstration

 ![img](https://i.imgur.com/3ayW5FZ.gif)
 
 ![img](https://i.imgur.com/GhpAOUn.png)
 
 ### Other
 
 If you don't wnat to compile the source check out for releases: https://github.com/Virgula0/Wifi-Inspector/releases
 
 ### Author
 
 Coded by Virgula August 2018
