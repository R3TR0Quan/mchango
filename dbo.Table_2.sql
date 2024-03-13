CREATE TABLE [dbo].[custom_expenses]
(
	[expense_Id] INT NOT NULL PRIMARY KEY, 
    [expenditure_name] VARCHAR(MAX) NOT NULL, 
    [amount] INT NOT NULL,
	[paid_by] VARCHAR(MAX) NOT NULL,
	[expense_date] DATE NOT NULL 
)
