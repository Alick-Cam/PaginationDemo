# Pagination Demo

A simple ASP.NET core web api project to demonstrate how pagination can be implemented.

The project exposes one endpoint; `GET /cars`. Use the swagger page for guidance to build valid requests.

>> Data is returned from a preloaded SQLite db that can be found at *src/Data/Database/pagination-demo.db*
The database has table named Cars with 100 records. Constraints on the data being queried can be seen on the swagger page.

## Run Locally

1. Navigate to a directory of choice.
2. Open a terminal and run `git clone https://github.com/Alick-Cam/PaginationDemo`
3. Install net8.0 sdk if you don't have it.
4. Navigate to the cloned repo and open PaginationDemo/src/Pagination.Demo.sln in your favourite .NET IDE.
5. Run Pagination.Demo.csproj