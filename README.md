# IDEODIGITAL
 Interview Task

 This is a server-side Customer Invoices App.

 App start on http://localhost:5050/

 The invoice has 4 fields:
 - Guid Id
 - DateTime Date
 - string Status
 - double Amount

 APP allows
 - Create a new Invoice (POST http://localhost:5050/invoices with JSON request 
 {
    "Amount"="{Amount}",
    "Date"="YYYY-MM-DD", //or "Date"="YYYY-MM-DDTHH:MM:SS.MSMSZ"
    "Status"="{Status}"
 }) Every Field can be empty.

 - View all Invoices (GET http://localhost:5050/invoices/all)

 - View Invoice by ID (GET http://localhost:5050/invoices?invoiceId={ID})

 - Change existing invoice by ID (PATCH http://localhost:5050/invoices with JSON request to update
 {
    "Amount"="{Amount}",
    "Date"="YYYY-MM-DD", //or "Date"="YYYY-MM-DDTHH:MM:SS.MSMSZ"
    "Status"="{Status}"
 }) Every Field can be empty.


There is error handling which allow "stupid-user" scenarios.

After the App restarts all previous data will be lost!