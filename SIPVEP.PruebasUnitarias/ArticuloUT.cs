using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIPVEP.CapaLogica;
using SIPVEP.Entidades;

namespace SIPVEP.PruebasUnitarias
{
    [TestClass]
    public class ArticuloUT
    {
        //Insertar

        [TestMethod]
        public void InsertarArticuloNoSku()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                sku = "",
                nombre = "LAPIZ NO 2",
                descripcion = "Lapiz de carbón Prismacolor No 2",
                precio_compra =  1.5,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Insertar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void InsertarArticuloSkuRepetido()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                sku = "123456789123",
                nombre = "LAPIZ NO 2",
                descripcion = "Lapiz de carbón Prismacolor No 2",
                precio_compra = 1.5,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Insertar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void InsertarArticuloNombreMenor5()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                sku = "123456789124",
                nombre = "GOMA",
                descripcion = "Goma para lápiz No 2",
                precio_compra = 1.5,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Insertar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void InsertarArticuloNombreMayor50()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                sku = "123456789124",
                nombre = "GOMA DE GOMA DE GOMA GOMA DE GOMA DE GOMA GOMA GOMA",
                descripcion = "Goma para lápiz No 2",
                precio_compra = 1.5,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Insertar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void InsertarArticuloNombreDescripcionMayor200()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                sku = "123456789124",
                nombre = "GOMA DE LAPIZ",
                descripcion = @"Goma para lápiz No 2Goma para lápiz No 2Goma para 
                    lápiz No 2Goma para lápiz No 2Goma para lápiz No 2Goma para 
                    lápiz No 2Goma para lápiz No 2Goma para lápiz No 2Goma para 
                    lápiz No 2Goma para lápiz No 21123456",
                precio_compra = 1.5,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Insertar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void InsertarArticuloPrecioCompra0()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                sku = "123456789124",
                nombre = "GOMA PARA LAPIZ",
                descripcion = "Goma para lápiz No 2",
                precio_compra = -3,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Insertar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void InsertarArticuloPrecioVentaMenor5Porciento()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                sku = "123456789125",
                nombre = "GOMA DE LAPIZ",
                descripcion = "Goma para lápiz No 2",
                precio_compra = 1.5,
                precio_venta = 1.57,
                stock = 100
            };


            //Act
            articuloLogica.Insertar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void InsertarArticuloStoxk0()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                sku = "123456789125",
                nombre = "GOMA DE LAPIZ",
                descripcion = "Goma para lápiz No 2",
                precio_compra = 1.5,
                precio_venta = 1.7,
                stock = 0
            };


            //Act
            articuloLogica.Insertar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }

        //Modificar

        [TestMethod]
        public void ModificarArticuloNoId()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                Id = 0,
                sku = "123456789123",
                nombre = "LAPIZ NO 2",
                descripcion = "Lapiz de carbón Prismacolor No 2",
                precio_compra = 1.5,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Modificar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void ModificarArticuloNoSku()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                Id = 1,
                sku = "",
                nombre = "LAPIZ NO 2",
                descripcion = "Lapiz de carbón Prismacolor No 2",
                precio_compra = 1.5,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Modificar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void ModificarArticuloIdNoExiste()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                Id = 3,
                sku = "123456789123",
                nombre = "LAPIZ NO 2",
                descripcion = "Lapiz de carbón Prismacolor No 2",
                precio_compra = 1.5,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Modificar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void ModificarArticuloNombreMenor5()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                Id = 2,
                sku = "123456789124",
                nombre = "GOMA",
                descripcion = "Goma para lápiz No 2",
                precio_compra = 1.5,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Modificar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void ModificarArticuloNombreMayor50()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                Id = 2,
                sku = "123456789124",
                nombre = "GOMA DE GOMA DE GOMA GOMA DE GOMA DE GOMA GOMA GOMA",
                descripcion = "Goma para lápiz No 2",
                precio_compra = 1.5,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Modificar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void ModificarArticuloNombreDescripcionMayor200()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                Id = 2,
                sku = "123456789124",
                nombre = "GOMA DE LAPIZ",
                descripcion = @"Goma para lápiz No 2Goma para lápiz No 2Goma para 
                    lápiz No 2Goma para lápiz No 2Goma para lápiz No 2Goma para 
                    lápiz No 2Goma para lápiz No 2Goma para lápiz No 2Goma para 
                    lápiz No 2Goma para lápiz No 21123456",
                precio_compra = 1.5,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Modificar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void ModificarArticuloPrecioCompra0()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                Id = 2,
                sku = "123456789124",
                nombre = "GOMA PARA LAPIZ",
                descripcion = "Goma para lápiz No 2",
                precio_compra = -3,
                precio_venta = 2,
                stock = 100
            };


            //Act
            articuloLogica.Modificar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void ModificarArticuloPrecioVentaMenor5Porciento()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                Id= 2,
                sku = "123456789125",
                nombre = "GOMA DE LAPIZ",
                descripcion = "Goma para lápiz No 2",
                precio_compra = 1.5,
                precio_venta = 1.57,
                stock = 100
            };


            //Act
            articuloLogica.Modificar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void ModificarArticuloStoxkCambio()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = new Articulo
            {
                Id = 2,
                sku = "123456789124",
                nombre = "GOMA DE LAPIZ",
                descripcion = "Goma para lápiz No 2",
                precio_compra = 1.5,
                precio_venta = 1.7,
                stock = 99
            };


            //Act
            articuloLogica.Modificar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]
        public void ModificarArticuloCorrecto()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();
            var articulo = articuloLogica.BuscarArticulo(2);
            articulo.precio_compra = 2;
            articulo.precio_venta = 4;


            //Act
            articuloLogica.Modificar(articulo);

            //Assert
            Assert.AreNotEqual(articulo.Id, null);
        }
        [TestMethod]

        //Merma

        public void MermaArticuloNoId()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();      

            //Act
            var a = articuloLogica.Merma(0,20);

            //Assert
            Assert.AreNotEqual(a.Id, 0);
        }
        [TestMethod]
        public void MermaArticuloNoExisteId()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();

            //Act
            var a = articuloLogica.Merma(3, 20);

            //Assert
            Assert.AreNotEqual(a.Id, 0);
        }
        [TestMethod]
        public void MermaArticuloSinExistencias()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();

            //Act
            var a = articuloLogica.Merma(1, 20);

            //Assert
            Assert.AreNotEqual(a.Id, 0);
        }
        [TestMethod]
        public void MermaArticuloMayorAexistencias()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();

            //Act
            var a = articuloLogica.Merma(2, 101);

            //Assert
            Assert.AreNotEqual(a.Id, 0);
        }
        [TestMethod]
        public void MermaArticuloCorrecta()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();

            //Act
            var a = articuloLogica.Merma(2, 20);

            //Assert
            Assert.AreNotEqual(a.Id, 0);
        }
        [TestMethod]

        //Aumento

        public void AumentoArticuloNoId()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();

            //Act
            var a = articuloLogica.AumentaExistencias(0, 20);

            //Assert
            Assert.AreNotEqual(a.Id, 0);
        }
        [TestMethod]
        public void AumentoArticuloNoExisteId()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();

            //Act
            var a = articuloLogica.AumentaExistencias(3, 20);

            //Assert
            Assert.AreNotEqual(a.Id, 0);
        }
        [TestMethod]
        public void AumentaArticuloSinExistencias()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();

            //Act
            var a = articuloLogica.AumentaExistencias(1, 20);

            //Assert
            Assert.AreNotEqual(a.Id, 0);
        }
        [TestMethod]
        public void AumentaArticulo0()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();

            //Act
            var a = articuloLogica.AumentaExistencias(2, 0);

            //Assert
            Assert.AreNotEqual(a.Id, 0);
        }
        [TestMethod]
        public void AumentaArticuloCorrecta()
        {
            //Arrange
            var articuloLogica = new ArticuloLogica();

            //Act
            var a = articuloLogica.AumentaExistencias(2, 20);

            //Assert
            Assert.AreNotEqual(a.Id, 0);
        }
    }
}
