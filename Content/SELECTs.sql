-- APOIO NEGOCIO
SELECT * FROM apoionegocio.categoria;
SELECT * FROM apoionegocio.classificacao;
SELECT * FROM apoionegocio.genero;
SELECT * FROM apoionegocio.midia;
SELECT * FROM apoionegocio.participantes;
SELECT * FROM apoionegocio.tipo_midia;

-- CATALOGO
SELECT * FROM catalogo.catalogo;

-- LEGADO
SELECT * FROM legado.monolito;

SELECT ctg.id AS 'ID CATÁLOGO',
        ctg.preco as 'PREÇO',
        ctg.caminho as 'CAMINHO',
        cat.nome as 'CATEGORIA',
        clas.nome as 'CLASSIFICAÇÃO',
        g.nome as 'GÊNERO',
        m.nome as 'MÍDIA',
        p.nome as 'PARTICIPANTES',
        tp.nome as 'TIPO MÍDIA'
FROM catalogo.CATALOGO ctg
JOIN apoionegocio.categoria cat ON ctg.id_categoria = cat.id
JOIN apoionegocio.classificacao clas  ON ctg.id_classificacao = clas.id
JOIN apoionegocio.genero g ON ctg.id_genero = g.id
JOIN apoionegocio.midia m ON ctg.id_midia = m.id
JOIN apoionegocio.participantes p ON ctg.id_participante = p.id
JOIN apoionegocio.tipo_midia tp ON ctg.id_tipo_midia = tp.id;