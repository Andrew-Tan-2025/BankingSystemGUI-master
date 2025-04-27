# BankingSystemGUI Section

When a user first accesses the application, they are redirected to the Login page where they can:
- Sign in using their username and password
- Create a new account if they don't have one

![p1](https://github.com/user-attachments/assets/1a1202f6-4ed6-4333-8134-8c35c28fec81)

When creating an account, the user provides:
- First name
- Last name
- Username (checked for uniqueness)
- Password (which gets encrypted with SHA)

After account creation:
- The username and encrypted password are stored
- The user's bank information (including randomly generated account numbers) is stored

![pp](https://github.com/user-attachments/assets/200672c0-53ca-43dd-81b1-41bf06fe8e10)

Upon successful login:
- The user is redirected and can see their Account Number and Balance
- They can access the Stock Market Portal to fetch requirements as indicated in List of Available Services:

We need 2, and this implementation "can be 2 services" as stated below. I think this service makes the most sense based on what we are making, so figured I would implement it.
```
Service 6. Stock Build and Quote (It can be two services)

Description: Download a stock price page, for example:  
http://nasdaq.com,  https://polygon.io/, http://iexcloud.io  
http://www.wsj.com/mdc/public/page/2_3024-NYSE.html 
https://www.wsj.com/market-data/stocks

Operation1 calls a stock service or API and process the data to provide the required 
output. Or, it analyzes the online data to obtain the open price of each stock symbol. 
Save the (symbol price) pairs into a file.  
Note, this operation should, but does not have to work for all stock pages. For 
workload purpose, it is fine for this operation to work for the given NYSE page only.

Operation2 (optional) reads the file generated from operation1 and returns the stock 
price of the given stock symbol 
Operation1: string Stockbuild(string sourceURL); // return file name to the (symbol 
price) pairs.  
Operation2: string Stockquote(string symbol); // return the stock price of the given stock 
symbol in string or float.
```

![p2](https://github.com/user-attachments/assets/513bd3c7-b020-4284-b647-552a53d728e9)

---

### Where is the data stored?

The data is located in a folder called "Data", which is in this path: bin/Debug/net8.0-windows/Data/

```
BankingSystemGUI/
├─ bin/
│  ├─ Debug/
│  │  └─ net8.0-windows/
│  │     ├─ Data/
│  │     │  ├─ AccountLogins.xml
│  │     │  ├─ BankInfo.xml
│  │     │  └─ StockData.xml
│  │     ├─ BankingSystemGUI.deps.json
│  │     ├─ BankingSystemGUI.dll
│  │     ├─ BankingSystemGUI.exe
│  │     ├─ BankingSystemGUI.pdb
│  │     ├─ BankingSystemGUI.runtimeconfig.json
│  │     └─ zipcode_response.xml
│  └─ Release/
│     └─ net8.0-windows/
├─ Forms/
│  ├─ AccountDetailsForm.cs
│  ├─ AccountDetailsForm.Designer.cs
│  ├─ LoginForm.cs
│  ├─ LoginForm.Designer.cs
│  ├─ LoginForm.resx
│  ├─ RegisterForm.cs
│  ├─ RegisterForm.Designer.cs
│  ├─ RegisterForm.resx
│  ├─ StockForm.cs
│  ├─ StockForm.Designer.cs
│  └─ StockForm.resx
├─ Helpers/
│  ├─ AccountNumberGenerator.cs
│  └─ PasswordHelper.cs
├─ Models/
│  ├─ BankAccount.cs
│  ├─ Stock.cs
│  └─ User.cs
├─ obj/
│  ├─ Debug/
│  │  └─ net8.0-windows/
│  │     ├─ ref/
│  │     │  └─ BankingSystemGUI.dll
│  │     ├─ refint/
│  │     │  └─ BankingSystemGUI.dll
│  │     ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│  │     ├─ apphost.exe
│  │     ├─ BankingSystemGUI.AssemblyInfo.cs
│  │     ├─ BankingSystemGUI.AssemblyInfoInputs.cache
│  │     ├─ BankingSystemGUI.assets.cache
│  │     ├─ BankingSystemGUI.csproj.BuildWithSkipAnalyzers
│  │     ├─ BankingSystemGUI.csproj.CoreCompileInputs.cache
│  │     ├─ BankingSystemGUI.csproj.FileListAbsolute.txt
│  │     ├─ BankingSystemGUI.csproj.GenerateResource.cache
│  │     ├─ BankingSystemGUI.designer.deps.json
│  │     ├─ BankingSystemGUI.designer.runtimeconfig.json
│  │     ├─ BankingSystemGUI.dll
│  │     ├─ BankingSystemGUI.Form1.resources
│  │     ├─ BankingSystemGUI.Forms.LoginForm.resources
│  │     ├─ BankingSystemGUI.Forms.RegisterForm.resources
│  │     ├─ BankingSystemGUI.Forms.StockForm.resources
│  │     ├─ BankingSystemGUI.GeneratedMSBuildEditorConfig.editorconfig
│  │     ├─ BankingSystemGUI.genruntimeconfig.cache
│  │     ├─ BankingSystemGUI.GlobalUsings.g.cs
│  │     ├─ BankingSystemGUI.pdb
│  │     └─ BankingSystemGUI.sourcelink.json
│  ├─ Release/
│  │  └─ net8.0-windows/
│  │     ├─ ref/
│  │     ├─ refint/
│  │     ├─ .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│  │     ├─ BankingSystemGUI.AssemblyInfo.cs
│  │     ├─ BankingSystemGUI.AssemblyInfoInputs.cache
│  │     ├─ BankingSystemGUI.assets.cache
│  │     ├─ BankingSystemGUI.GeneratedMSBuildEditorConfig.editorconfig
│  │     └─ BankingSystemGUI.GlobalUsings.g.cs
│  ├─ BankingSystemGUI.csproj.nuget.dgspec.json
│  ├─ BankingSystemGUI.csproj.nuget.g.props
│  ├─ BankingSystemGUI.csproj.nuget.g.targets
│  ├─ project.assets.json
│  └─ project.nuget.cache
├─ Services/
│  ├─ AuthService.cs
│  ├─ FileService.cs
│  └─ StockService.cs
├─ BankingSystemGUI.csproj
├─ BankingSystemGUI.csproj.user
├─ BankingSystemGUI.sln
├─ Form1.cs
├─ Form1.Designer.cs
├─ Form1.resx
└─ Program.cs
```

---

<b>AccountLogins.xml</b> has the following structure:

```xml
<?xml version="1.0" encoding="utf-8"?>
<Users xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <User>
    <Username>kmora</Username>
    <Password>e14cb9e5c0eeee0ea313a4e04fbd10aa17ac17aa33a3cad4bdfe74b87ca18ef8</Password>
    <FirstName>Kevin</FirstName>
    <LastName>Mora</LastName>
  </User>
</Users>
```

<b>BankInfo.xml</b> has the following structure:

```xml
<?xml version="1.0" encoding="utf-8"?>
<BankAccounts xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <BankAccount>
    <FirstName>Kevin</FirstName>
    <LastName>Mora</LastName>
    <CheckingAccountNumber>CHK32636170</CheckingAccountNumber>
    <CheckingBalance>0</CheckingBalance>
    <SavingsAccountNumber>SAV91148238</SavingsAccountNumber>
    <SavingsBalance>0</SavingsBalance>
    <Username>kmora</Username>
  </BankAccount>
</BankAccounts>
```
