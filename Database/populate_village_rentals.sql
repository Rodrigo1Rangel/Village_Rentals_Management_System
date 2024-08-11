alter session set NLS_DATE_FORMAT='yyyy-mon-dd';
alter session set NLS_LANGUAGE = ENGLISH;

SET ECHO ON
SET VERIFY ON

set pagesize 66
set linesize 200 

spool C:\temp\populate_village_rentals.txt

rem Populate Village Rentals Management System

--------------------------------------------------------------------------------
-- VR_CATEGORIES
INSERT INTO VR_CATEGORIES(category_id, description) VALUES (10, 'Power tools');
INSERT INTO VR_CATEGORIES(category_id, description) VALUES (20, 'Yard equipment');
INSERT INTO VR_CATEGORIES(category_id, description) VALUES (30, 'Compressors');
INSERT INTO VR_CATEGORIES(category_id, description) VALUES (40, 'Generators');
INSERT INTO VR_CATEGORIES(category_id, description) VALUES (50, 'Air Tools');

--------------------------------------------------------------------------------
-- VR_EQUIPMENT
INSERT INTO VR_EQUIPMENT(equipment_id, category_id, description, name) VALUES (101, 10, 'Powerful drill for concrete and masonry', 'Hammer drill');
INSERT INTO VR_EQUIPMENT(equipment_id, category_id, description, name) VALUES (201, 20, 'Gas-powered chainsaw for cutting wood', 'Chainsaw');
INSERT INTO VR_EQUIPMENT(equipment_id, category_id, description, name) VALUES (202, 20, 'Self-propelled lawn mower with mulching function', 'Lawn mower');
INSERT INTO VR_EQUIPMENT(equipment_id, category_id, description, name) VALUES (301, 30, '5 Gallon Compressor-Portable', 'Small Compressor');
INSERT INTO VR_EQUIPMENT(equipment_id, category_id, description, name) VALUES (501, 50, 'Brad Nailer. Requires 3/4 to 1 1/2 Brad Nails', 'Brad Nailer');

--------------------------------------------------------------------------------
-- VR_EQUIPMENTFORSALE
-- INSERT INTO VR_EQUIPMENTFORSALE(equipment_id, price) VALUES (,);

--------------------------------------------------------------------------------
-- VR_RENTALEQUIPMENT
INSERT INTO VR_RENTALEQUIPMENT(equipment_id, daily_rental_cost) VALUES (101, 29.99);
INSERT INTO VR_RENTALEQUIPMENT(equipment_id, daily_rental_cost) VALUES (201, 49.99);
INSERT INTO VR_RENTALEQUIPMENT(equipment_id, daily_rental_cost) VALUES (202, 19.99);
INSERT INTO VR_RENTALEQUIPMENT(equipment_id, daily_rental_cost) VALUES (301, 14.99);
INSERT INTO VR_RENTALEQUIPMENT(equipment_id, daily_rental_cost) VALUES (501, 10.99);

--------------------------------------------------------------------------------
-- VR_RENTALEQUIPMENTINFO
INSERT INTO VR_RENTALEQUIPMENTINFO(equipment_id, rental_id, item_quantity, rent_date, return_date, rental_cost) VALUES (201, 1000, 1, '2024-feb-20', '2024-feb-23', 149.97);
INSERT INTO VR_RENTALEQUIPMENTINFO(equipment_id, rental_id, item_quantity, rent_date, return_date, rental_cost) VALUES (501, 1001, 1, '2024-feb-21', '2024-feb-25', 43.96);

--------------------------------------------------------------------------------
--  VR_CUSTOMERINFO
INSERT INTO VR_CUSTOMERINFO(customer_id, last_name, first_name, contact_phone, email, note) VALUES (1001, 'Doe', 'John', '555.555.1212', 'jd@sample.net', '');
INSERT INTO VR_CUSTOMERINFO(customer_id, last_name, first_name, contact_phone, email, note) VALUES (1002, 'Smith', 'Jane', '555.555.3434', 'js@live.com', '');
INSERT INTO VR_CUSTOMERINFO(customer_id, last_name, first_name, contact_phone, email, note) VALUES (1003, 'Lee', 'Michael', '555.555.5656', 'ml@sample.net', '');

--------------------------------------------------------------------------------
-- VR_RENTALINFO
INSERT INTO VR_RENTALINFO (rental_id, customer_id, equipment_id) VALUES (1000, 1001, 201);
INSERT INTO VR_RENTALINFO (rental_id, customer_id, equipment_id) VALUES (1001, 1002, 501);

COMMIT;