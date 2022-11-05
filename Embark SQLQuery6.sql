/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id_destino]
      ,[preco]
      ,[data_da_viagem]
      ,[destno]
      ,[veiculo]
  FROM [Embark].[dbo].[Pct_viagem]