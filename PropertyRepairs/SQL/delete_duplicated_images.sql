BEGIN TRAN;

DELETE i
FROM Images i
INNER JOIN (
  SELECT Filename, MIN(Id) AS KeepId
  FROM Images
  GROUP BY Filename
) k ON i.Filename = k.Filename
WHERE i.Id <> k.KeepId;

COMMIT TRAN;
