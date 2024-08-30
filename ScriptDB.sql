CREATE DATABASE Parcial01
GO

USE Parcial01
GO

CREATE TABLE Productos(
Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nombre VARCHAR(100) NOT NULL,
Descripcion VARCHAR(100) NOT NULL,
Precio DECIMAL(10,2) NOT NULL,
Stock INT NOT NULL,
Marca VARCHAR(50) NOT NULL,
Categoria VARCHAR(50) NOT NULL
);
GO

INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, Marca, Categoria)
VALUES 
('Laptop', 'Laptop con pantalla de 15.6 pulgadas y procesador Intel i7', 1500.00, 20, 'HP', 'Computadoras'),
('Smartphone', 'Smartphone con pantalla AMOLED de 6.4 pulgadas y 128GB de almacenamiento', 899.99, 50, 'OnePlus', 'Tel�fonos'),
('Tablet', 'Tablet de 10.5 pulgadas con soporte para l�piz �ptico', 600.00, 35, 'Apple', 'Tabletas'),
('Auriculares', 'Auriculares inal�mbricos con cancelaci�n de ruido activa', 299.99, 100, 'Sony', 'Audio'),
('Smartwatch', 'Reloj inteligente con monitor de frecuencia card�aca y GPS', 250.00, 45, 'Garmin', 'Wearables');
GO