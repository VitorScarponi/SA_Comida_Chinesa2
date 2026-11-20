CREATE DATABASE IF NOT EXISTS DB_SAComidaChinesa
  CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

USE DB_SAComidaChinesa;

CREATE TABLE IF NOT EXISTS tblProdutos (
  id         INT AUTO_INCREMENT PRIMARY KEY,
  nome       VARCHAR(100)  NOT NULL,
  descricao  VARCHAR(255)  NOT NULL,
  preco      DECIMAL(10,2) NOT NULL,
  emoji      VARCHAR(16)   NOT NULL DEFAULT '🍽️',
  categoria  VARCHAR(20)   NOT NULL DEFAULT 'Prato',
  tag        VARCHAR(40)   NOT NULL DEFAULT '',
  ativo      TINYINT(1)    NOT NULL DEFAULT 1
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

INSERT INTO tblProdutos (nome, descricao, preco, emoji, categoria, tag) VALUES
('Yakisoba tradicional', 'Macarrão salteado com legumes e molho especial da casa.', 32.90, '🍜', 'Prato',   'Mais pedido'),
('Yakisoba de frango',   'Frango macio, vegetais frescos e aquele molho irresistível.', 34.90, '🥢', 'Prato',   'Favorito'),
('Combo oriental',       'Uma combinação generosa para dividir e aproveitar.', 49.90, '🥡', 'Combo',   'Para compartilhar'),
('Rolinho primavera',    'Crocante por fora, recheado e perfeito para começar.', 18.90, '🥟', 'Entrada', 'Entrada'),
('Arroz chop suey',      'Arroz soltinho preparado ao estilo oriental.', 27.90, '🍚', 'Prato',   'Clássico'),
('Legumes salteados',    'Uma mistura colorida de vegetais com tempero da casa.', 24.90, '🥦', 'Prato',   'Leve');
