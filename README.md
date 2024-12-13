This assignment was about creating a page for a small business owner who sells his own craftsmanship.
For starters, he wanted a pretty simple page, but with the possibility of it becoming more advanced.

To use this program, make sure either Visual Studio Code or Visual Studio is already installed on your computer.
1. In Github, click the green button that says " <> Code ", then under the page "Local" click the button that says " Donwload ZIP ".
2. Extract the folder and right-click the folder. The press "Show more options" and then "Open with code"
3. In VsCode, open the terminal and write "dotnet run".
4. In one of the info: box you will see a http://locallhost adress. Hold CTRL and click that link


I chose to create a MockRepository for the craftsmanships, and also a Products-class with all the necessary propertys as Name, Price, Description and Id.
By doing this, it's easy for when the customer wants to expand his list of products to sell. All that needs to be done is to change the MockRepository-file.
The MockRepository is one way of breaking down the code into tiny pieces that is easy to be used in more than one part of the program. It also makes it easy to manage and also easy to expand.
