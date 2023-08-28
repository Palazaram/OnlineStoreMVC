The web application is an online store for agricultural products developed using ASP.NET MVC Identity. During the development process, models were created for the database, including CartDetail, Category, Order, OrderList, OrderStatus, Product, ShoppingCart, Supplier, as well as corresponding tables for the Identity system.

FluentAPI was used to provide more flexible constraints and relationships between the models. The classes responsible for configuring these constraints are located in the ConfigureClasses folder.

To facilitate user organization and rights management, two roles were defined: "Admin" and "User." **Upon the first launch of the application using UserManager and RoleManager, a user with the "Admin" role is automatically created, using the email address "admin@gmail.com" and the password "**Admin@123**".** A user with the "Admin" role gains the ability to perform CRUD operations: adding, deleting, and editing products.

Validation was added to the product creation form to ensure correct data input and prevent errors when adding new products.

To make purchases, users need to be authorized. After registering on the site, users are assigned the "User" role, allowing them to purchase products, place orders, and view order history.

All information about products, orders, and users is stored in the database. Concurrently, user actions are recorded in the database, ensuring reliable data storage.

For user convenience, the store implements product filtering and pagination, making it easy to find and view relevant products.

Bootstrap library classes were used for styling the store's interface, enabling the creation of a modern and responsive design for the application.

**All images for creating products are in the Images folder**
