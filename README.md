# Saltazon

## Purpose
- Deep dive into authentication & authorisation
- Understand the set-up for password-hashing
- Learn to Sign JWT tokens and send back response

## Assignment
This is an eCommerce app (reminiscent of Amazon) that allows stores to create their own company sites on it and put up their own products (So exactly how on Amazon.com sellers will have their own Store page with all of their products that they sell). A regular customer that visits the site should be able to view all the products from each of the stores. And add whatever they find to their cart. And a store, or seller, should be able to upload new products to the store that the customer should see. The naming, additional styling of the website is of course completely up to you.

### App Requirements
- The app should be able to display products. There should be a filter bar and search for products. Each product should have its own page, where you can add products to your cart. This cart should persist in local storage, and only be visible if that user is logged in
- The backend should log each request from the clients in a document of your choice. Look up “backend logging”, if you need to know more. The log should include; type of request, date, status code
- The store and the backend should not be open to just anyone. Only an authenticated user (of any three roles) should be able to reach the store and its backend routes (using something called “protected routes”). It is important that this authentication is present in both your frontend and backend
- The app should have three different roles; Super Admin, Store Admin and User. 
    ##### Super Admin: 
        - This is the owner of the website. 
        - They can view all the different stores and their products
        - Super Admin can also delete products and entire Stores
        - This user can’t be created in the sign-up page. You create this beforehand
    ##### Store Admin: 
        - This is the owner of the store. 
        - These are able to upload and remove new products. With both info and a fitting image
    ##### User: 
        - This is the customer. 
        - A user can add products to their cart
        - Save their cart in local storage, and have that only visible by them 

### Page requirements
These are the pages we expect you to create. You are welcome to change smaller parts of the following page requirements if you want to, the most important part is that you follow the list of app requirements above.

#### Login & sign-up page 
##### The sign-in page
- Throwing an error if the user’s password is incorrect or if the email doesn’t exist (“Email or password is incorrect”).
- Signing a JWT Token and sending back in response.
{ token: “”, user: {email: “” ….} }
- User is redirected to the Home page
##### The sign-up page 
- Email, Password, Type of user (store admin or user)
- Validating if the email has already been used by an existing user
- Validating the inputs (validators like Joi can be used here)
- Password, requirements up to you,  & email is required in correct format
- Password and confirmed password should match
- Saving the user into the DB
- Make sure to encrypt the user's password as you are storing it in the database. Use a library like Bcrypt for this

#### Home page
- Same for all types of Roles
- Once the user is logged in, and redirected to the home page, we should fetch all the products and show them
- A search and filter for looking through products 
- Pagination 
- (optional) Each product also has a link to the store selling the products
When the user clicks on a product they will be redirected to the products page
##### User
    - Adding items to a cart, saved in local storage
    - Removing items from a cart
    - Updating quantity per item in a cart 

#### Profile page
##### User
- (optimal): Can view their entire cart
##### Store admin
- Add button for adding products
- See all the products their store is selling
- Can delete products
- (optional) A user can view this page, and see all the products a store is selling
##### Super Admin
- View all the different stores
- Can delete an entire store
- Can click on a store from the list and redirect to the Stores page. Here they can do everything as the store admin 

## Wireframe
![wireframe][def]

[def]: wireframe.png
