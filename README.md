# WestpacBuggyCars

# BuggyCarsRating
Testing automation using NUnit, Specflow, and Selenium for Buggy Cars Rating (https://buggy.justtestit.org/).

## Pre-requisites
- Visual Studio 2019
- .NUnit
- Drivers(Chrome)
- Git

## Setup
1. Clone the repository to your local machine
2. Open Visual Studio and open the solution
3. Install "SpecFlow for Visual Studio 2019" extension
4. Build the project 

## How to run the tests?
In Visual Studio menubar, go to Test and then click Test Explorer. And then click Run All Tests In View button. Easy!


## Testing Approach
Critical features and functionalities identified

**1. Registration and Login**
  - Register with valid data
  - Register an existing user
  - Login with valid credentials
  - Login with invalid credentials
  - Logout

**2. Rating Functionality**
  - Validate user can vote and comment on make detail page
  - Validate user can vote and comment on model detail page

**3. Overall Rating Page**
  - Display list of all registered models
  - Check pagination
  - Check sorting feature
  - Check broken images

Note: Test approach and planning doc is attached : TestApproachandPlanning.xslx

