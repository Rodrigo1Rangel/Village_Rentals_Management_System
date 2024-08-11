alter session set "_ORACLE_SCRIPT"=true; 
DROP USER villagerentals;
CREATE USER villagerentals
      IDENTIFIED BY password /* the user password is 'password' */
      DEFAULT TABLESPACE users;
ALTER USER villagerentals quota unlimited on users;
GRANT CREATE SESSION, RESOURCE, CONNECT, CREATE VIEW TO villagerentals;
