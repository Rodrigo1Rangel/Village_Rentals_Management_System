# **Village Rentals Management System**

Village Rentals is a fiction business that rents equipment. This software is a system that uses a relational database to track equipment, customers, and rentals.


## **Functionalities:**

### Manage the equipment inventory
This includes adding new equipment or removing equipment from inventory. Equipment that has been used, but still in working order can be removed from inventory and sold.

### Manage Customer Information
Enter the information for a new customer or update the information of a current customer. 

### Equipment Rental
Each rental has a unique number, the customer, the equipment, the rental date and return date.

### Equipment Category
Categories of equipments may be created and deleted.

### Generate Reports.
The system will allow for a selection of reports: sales by date; sales by customer, list items by category, other customizable reports.


## **Database**
**Singleton pattern** using **Oracle Database 21c Express Edition**.


## **Graphical User Interface (GUI)**
**Windows Forms .Net Framework**.

## **Exceptions**
The software contains exceptions to validate data entry, which includes mandatory fields, maximum length, pattern match (phone contact, email, and price), and measures to prevent SQL injection.