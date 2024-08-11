alter session set NLS_DATE_FORMAT='dd-mon-yy';
alter session set NLS_LANGUAGE = ENGLISH;

set pagesize 66
set linesize 200

spool C:\temp\villagerentals_build.txt

rem Village Rentals Management System

rem
rem ============================ DROP TABLES ====================================
rem

DROP TABLE VR_EQUIPMENT
CASCADE CONSTRAINTS;

DROP TABLE VR_CATEGORIES
CASCADE CONSTRAINTS;

DROP TABLE VR_RENTALEQUIPMENT
CASCADE CONSTRAINTS;

DROP TABLE VR_EQUIPMENTFORSALE
CASCADE CONSTRAINTS;

DROP TABLE VR_RENTALEQUIPMENTINFO
CASCADE CONSTRAINTS;

DROP TABLE VR_RENTALINFO
CASCADE CONSTRAINTS;

DROP TABLE VR_CUSTOMERINFO 
CASCADE CONSTRAINTS;


rem
rem =========================== CREATE TABLES ===================================
rem
SET ECHO ON
SET FEEDBACK ON

CREATE TABLE VR_CATEGORIES
(category_id NUMBER CONSTRAINT categories_category_id_nn NOT NULL,
description VARCHAR2(100) CONSTRAINT category_description_nn NOT NULL,
CONSTRAINT category_category_id_pk PRIMARY KEY (category_id));

CREATE TABLE VR_EQUIPMENT
(equipment_id NUMBER CONSTRAINT equipment_equipment_id_nn NOT NULL,
category_id NUMBER CONSTRAINT equipment_category_id_nn NOT NULL,
description VARCHAR2(100), -- NN?
name VARCHAR2(50) CONSTRAINT category_name_nn NOT NULL,
CONSTRAINT equipment_category_id_fk FOREIGN KEY (category_id)
REFERENCES VR_CATEGORIES(category_id),
CONSTRAINT equipment_equipment_id_pk PRIMARY KEY (equipment_id));

CREATE TABLE VR_EQUIPMENTFORSALE
(equipment_id NUMBER CONSTRAINT equipforsale_equipment_id_nn NOT NULL, 
price NUMBER(*,2) CONSTRAINT equipforsale_price_nn NOT NULL,
CONSTRAINT equipforsale_equipment_id FOREIGN KEY (equipment_id)
REFERENCES VR_EQUIPMENT(equipment_id),
CONSTRAINT equipforsale_equipment_id_pk PRIMARY KEY (equipment_id));

CREATE TABLE VR_RENTALEQUIPMENT
(equipment_id NUMBER CONSTRAINT rentequip_equipment_id_nn NOT NULL, 
daily_rental_cost NUMBER(*,2) CONSTRAINT rentequip_drc_nn NOT NULL,
CONSTRAINT rentequip_equipment_id FOREIGN KEY (equipment_id)
REFERENCES VR_EQUIPMENT(equipment_id),
CONSTRAINT rentequip_equipment_id_pk PRIMARY KEY (equipment_id));

CREATE TABLE VR_RENTALEQUIPMENTINFO (
equipment_id NUMBER CONSTRAINT rentequipinfo_equipment_id_nn NOT NULL,
rental_id NUMBER CONSTRAINT rentequipinfo_rental_id_nn NOT NULL,
item_quantity NUMBER DEFAULT 0,
rent_date DATE CONSTRAINT rentequipinfo_rent_date_nn NOT NULL,
return_date DATE CONSTRAINT rentequipinfo_return_date_nn NOT NULL,
rental_cost NUMBER(*,2) CONSTRAINT rentequipinfo_rental_cost_nn NOT NULL,
CONSTRAINT rentequipinfo_equip_id_fk FOREIGN KEY (equipment_id)
REFERENCES VR_RENTALEQUIPMENT(equipment_id),
CONSTRAINT rentequipinfo_equip_rent_id_pk PRIMARY KEY (equipment_id, rental_id));

CREATE TABLE VR_CUSTOMERINFO (
customer_id NUMBER CONSTRAINT customerinfo_customer_id_nn NOT NULL,
last_name VARCHAR2(50) CONSTRAINT customerinfo_last_name_nn NOT NULL,
first_name VARCHAR2(50) CONSTRAINT customerinfo_first_name_nn NOT NULL,
contact_phone VARCHAR2(12) CONSTRAINT customerinfo_contact_phone_nn NOT NULL,
email VARCHAR2(100) CONSTRAINT customerinfo_email_nn NOT NULL,
note VARCHAR2(500),
CONSTRAINT customerinfo_contact_phone_ck CHECK (REGEXP_LIKE (contact_phone, '^\d{3}.\d{3}.\d{4}$')),
CONSTRAINT customerinfo_email_ck CHECK (REGEXP_LIKE (email, '^\w+@\w+.\w+(.\w+||.\w+.\w+)$')),
CONSTRAINT customerinfo_customer_id_pk PRIMARY KEY (customer_id));

CREATE TABLE VR_RENTALINFO (
rental_id NUMBER CONSTRAINT rentalinfo_rental_id_nn NOT NULL,
customer_id NUMBER CONSTRAINT rentalinfo_customer_id NOT NULL,
equipment_id NUMBER CONSTRAINT rentalinfo_equipment_id NOT NULL,
CONSTRAINT rentalinfo_rental_id_fk FOREIGN KEY (rental_id, equipment_id)
REFERENCES VR_RENTALEQUIPMENTINFO (rental_id, equipment_id),
CONSTRAINT rentalinfo_customer_id_fk FOREIGN KEY (customer_id)
REFERENCES VR_CUSTOMERINFO (customer_id),
CONSTRAINT rentalinfo_rentcustequip_id_pk PRIMARY KEY (rental_id, customer_id, equipment_id));
-- should all three be PK or just rental_id and equipment_id?


spool off

-- BINARY_DOUBLE: https://docs.oracle.com/en/database/oracle/oracle-database/19/sqlrf/Data-Types.html