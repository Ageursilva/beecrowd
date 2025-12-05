SELECT prod.name AS product, prov.name AS provider
FROM products prod
    JOIN providers prov ON prod.id_providers = prov.id
WHERE prod.id_categories = 6;