# Vendor Order

#### C# Week Three Friday Project _March 13th 2020_

#### By _**Keturah Howard**_

## Description

.

This project is being created with the intention of practing spec creation, redgreen workflow and basic MSTesting with C#.

## Specifications:


| Specification | Example Input | Example Output |
| :------------- |:-------------| :-------------------|
| 1. Splash page is presented | Pierre opens his application | *Vendors and Orders Main Page* displays |
| 2. Pierre can navigate to *vendor list* page (from any page) | Pierre clicks on *Vendor List* link | *Vendor Page* displays, with a message that says "no current vendors" |
| 3. Pierre can navigate to *new vendor* page (from any page) | Pierre clicks on *New Vendor* link | *Vendor form* displays |
| 4. Pierre can submit new vendor form | Pierre fills form, presses submit | form info, such as *Vendor name, description, **list of orders*** is created |
| 5. Vendor list apears after form submit | Pierre fills form, presses submit | next page displays, including the new *Vendor's name* he had filled out in the form |
| 6. Individual Vendors are clickable | Pierre is on Vendor page, clicks on Vendor's Name | That individual Vendor's page displays, including the individual Vendor's name and description and List of orders |
| 7. Pierre can add Orders to Vendors that already exist | Pierre is on *specific* Vendor page, clicks on *[add order] button* | Form displays with ability to take in specific order's and add them to the list of Orders for that particular Vendor |
 


## Setup/Installation Requirements

  ### Installing .NET Core

  #### macOS
  * Download a .NET Core SDK from Microsoft Corp
  * Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.

  #### on Windows
  * Download the 64-bit .NET Core SDK from Microsoft Corp.
  * Open the .exe file and follow the steps provided by the installer for your OS.

  ### Installing This Application

  1. Click on the *clone or download* button of this repository. You can download the project file clicking the **"Download Zip"** button, double clicking the file in downloads, and navigating to the index.html file and double clicking that. *Or*, you can copy the link that pops up when you've clicked the *clone or download* button above this README.md file...
  2. Navigate to your terminal, where you have previously installed git (if you have not done this yet, go ahead and do so now).
  3. In terminal, change your directory to desktop, and then type **git clone https://github.com/KeturahDev/WordCount.git**.
  4. When you've pressed enter, my project will be cloned onto your desktop, and now you can change directory into it and type **"code ."** to open the projects files in Visual Studio Code!
  5. You will now be at the root directory for this project in your chosen command promt program. Navigate to *WordCounter.Tests* directory. Enter the command **"dotnet restore"**.
  6. Now navigate back to root directory, and into *WordCount* directory, an input **dotnet run**
  7. Enjoy!

## Technologies Used

* Git
* VS Code
* C#
* .NET 2.2


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email me at keturah.dev@gmail.com.

## License

This HTML web page is licensed under the MIT license.

## Copyright

Copyright (c) 2020 Keturah Howard.