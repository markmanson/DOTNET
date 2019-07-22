----ABS/ABSVAL----
SELECT ABS(-3);

---ROUND------
SELECT ROUND(123.9994, 3);

---ISNUMERIC----
SELECT IsNumeric(1);

SELECT ISNumeric('Monal');

--SQUARE---
SELECT SQUARE(2);

--Rand----
SELECT RAND();

--CEILING-----
Select ceiling(15.59);

---Floor---
SELECT Floor(25.95);  

---SQRT----
SELECT SQRT(3421E+09);
SELECT SQRT (CAST(25 AS FLOAT));






----ACOS-----
Select ACOS(0.20);

---ASIN-------
Select ASIN(0.20);

---ATAN-----
SELECT Atan(0.20);

----CAST-----
Select CAST((1210.73)AS INT);

---COS--------
Select COS(0.20);

---Concatenetion Function--
Select FirstName+ ' ' +LastName from dbo.Employees;

--DEGREES---
SELECT Degrees(25.65);

--EXP----
SELECT EXP(4);

---LOG----
SELECT LOG(2);

---LOG10----
SELECT LOG10(2);

---mod----
SELECT (10%2);

--PI---
SELECT PI();

--Radians--
Select radians(5.15454);

---SIN---
SELECT SIN(2);

---TAN----
SELECT TAN(2);




----Current DATE---
SELECT GETDATE();


----GETUTCDATE-----
Select GETUTCDATE();


--DAY-----
Select DAY('2010-08-13');

---month---
Select MONTH('03/12/1998');

---YEAR---
SELECT YEAR('2010/08/16'); 

---DATENAME-----
SELECT DATENAME(month, getdate()) AS 'Month Name';

--DATEPART
SELECT DATEPART(month, GETDATE()) AS 'Month Number';

SELECT DATEPART(m, 0), DATEPART(d, 0), DATEPART(yy, 0);

--DATEADD----
SELECT DATEADD(day, 21,'2010/3/19') AS  timeframe;

--DATEDIFF
SELECT DATEDIFF(day,'2010/3/19',  getdate())  AS no_of_days; 

--ISDATE

SELECT ISDATE('2010/3/19');



---Current TimeStamp
SELECT CURRENT_TIMESTAMP;

---CURRENT_USER OR SESSIONUSER
SELECT Session_USER;  ---OR-- 
SELECT USER;  ---OR--
Select Current_User;



---LEN---
Select LEN('Raj'), LEN('Raj    ');


---UPPER----
SELECT Upper('monal');

---Lower----
SELECT Lower('MONAL');


---LTRIM-----
SELECT LTRIM('   Raj');

---RTRIM--
SELECT RTRIM('RAJ    ');

---SUBSTR---
SELECT SUBSTRING('hello', 2,4);

--LEFT-----
Select LEFT('Monal',2);

---Right-------
Select RIGHT('MONAL',2);

---Replace-----
SELECT REPLACE('Beniwal', 'Beniwal', 'Choudhary');

---Reverse----
Select Reverse ('Monal');


---CHARINDEX--------
SELECT CHARINDEX('w', 'Beniwal');

--PATINDEX----
SELECT PATINDEX('%na%','Monal');

---SPACE----
SELECT 'Monal'+ ',' + SPACE(2) +'Shah' ;






--nullif---
SELECT nullif(3,0);

--case----
SELECT  EmployeeID, 
		CASE EmployeeID
			WHEN 1 THEN 2
			WHEN 4  THEN 5
			ELSE 7
		END
From dbo.Employees


---COALESCE-----
SELECT COALESCE('2010-02-05', '1900-01-01') AS NewDate;

--ISNULL---
SELECT ISNULL('1989-02-05', '1900-01-01') AS NewDate;


--Grouping
SELECT GROUPING(Title) 'Titlegrp' 
FROM dbo.Employees
GROUP BY Title
With rollup;


---Convert--
SELECT Distinct convert(varchar,OrderDate,111)
From  dbo.Orders;


