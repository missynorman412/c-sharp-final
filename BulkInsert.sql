BULK INSERT ImportDB
FROM 'C:\Users\Acer\source\repos\Final\Final\bin\Debug\TaskList.csv'
WITH (FIELDTERMINATOR = ',',
	ROWTERMINATOR = '\n');