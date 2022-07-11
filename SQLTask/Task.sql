SELECT
	Prodacts.id,
	Prodacts.info,
	Prodacts_KindOfProdacts.id_Prodacts,
	Prodacts_KindOfProdacts.id_KindOfProdacts
FROM Prodacts
LEFT JOIN Prodacts_KindOfProdacts ON Prodacts.id = Prodacts_KindOfProdacts.id_Prodacts;