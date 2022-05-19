using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIPVEP.CapaLogica;
using SIPVEP.Entidades;

namespace SIPVEP.PruebasUnitarias
{
    [TestClass]
    public class ProvedorUT
    {
        [TestMethod]
        public void InsertarProvedorMalRFC()
        {
            //Arrange
            var provedorLogica = new ProvedorLogica();
            var provedor = new Provedor()
            {
               rfc = "CEC941104AN512",
               razon_social = "",
               direccion_fiscal = "",
               cp_fiscal = "",
               ciudad_fiscal = "",
               estado_fiscal = "",
               nombre_alias = "",
               correo_fiscal = "",
               direccion = "",
               telefono = "",
               correo_contacto = ""
            };


            //Act
            provedorLogica.Insertar(provedor);

            //Assert
            Assert.AreNotEqual(provedor.rfc, null);
        }
        [TestMethod]
        public void InsertarProvedorMalRazonSocial()
        {
            //Arrange
            var provedorLogica = new ProvedorLogica();
            var provedor = new Provedor()
            {
                rfc = "CEC941104AN5",
                razon_social = "",
                direccion_fiscal = "",
                cp_fiscal = "",
                ciudad_fiscal = "",
                estado_fiscal = "",
                nombre_alias = "",
                correo_fiscal = "",
                direccion = "",
                telefono = "",
                correo_contacto = ""
            };


            //Act
            provedorLogica.Insertar(provedor);

            //Assert
            Assert.AreNotEqual(provedor.rfc, null);
        }
        [TestMethod]
        public void InsertarProvedorMalDireccion()
        {
            //Arrange
            var provedorLogica = new ProvedorLogica();
            var provedor = new Provedor()
            {
                rfc = "CEC941104AN5",
                razon_social = "COLEGIO DE ESTUDIOS CIENTIFICOS Y TECNOLOGICOS DEL ESTADO DE VERACRUZ",
                direccion_fiscal = "",
                cp_fiscal = "",
                ciudad_fiscal = "",
                estado_fiscal = "",
                nombre_alias = "",
                correo_fiscal = "",
                direccion = "",
                telefono = "",
                correo_contacto = ""
            };


            //Act
            provedorLogica.Insertar(provedor);

            //Assert
            Assert.AreNotEqual(provedor.rfc, null);
        }
        [TestMethod]
        public void InsertarProvedorMalCP()
        {
            //Arrange
            var provedorLogica = new ProvedorLogica();
            var provedor = new Provedor()
            {
                rfc = "CEC941104AN5",
                razon_social = "COLEGIO DE ESTUDIOS CIENTIFICOS Y TECNOLOGICOS DEL ESTADO DE VERACRUZ",
                direccion_fiscal = "Manuel R Gutierrez #12",
                cp_fiscal = "",
                ciudad_fiscal = "",
                estado_fiscal = "",
                nombre_alias = "",
                correo_fiscal = "",
                direccion = "",
                telefono = "",
                correo_contacto = ""
            };


            //Act
            provedorLogica.Insertar(provedor);

            //Assert
            Assert.AreNotEqual(provedor.rfc, null);
        }
        [TestMethod]
        public void InsertarProvedorMalCiudad()
        {
            //Arrange
            var provedorLogica = new ProvedorLogica();
            var provedor = new Provedor()
            {
                rfc = "CEC941104AN5",
                razon_social = "COLEGIO DE ESTUDIOS CIENTIFICOS Y TECNOLOGICOS DEL ESTADO DE VERACRUZ",
                direccion_fiscal = "Manuel R Gutierrez #12",
                cp_fiscal = "91030",
                ciudad_fiscal = "",
                estado_fiscal = "",
                nombre_alias = "",
                correo_fiscal = "",
                direccion = "",
                telefono = "",
                correo_contacto = ""
            };


            //Act
            provedorLogica.Insertar(provedor);

            //Assert
            Assert.AreNotEqual(provedor.rfc, null);
        }
        [TestMethod]
        public void InsertarProvedorMalEstado()
        {
            //Arrange
            var provedorLogica = new ProvedorLogica();
            var provedor = new Provedor()
            {
                rfc = "CEC941104AN5",
                razon_social = "COLEGIO DE ESTUDIOS CIENTIFICOS Y TECNOLOGICOS DEL ESTADO DE VERACRUZ",
                direccion_fiscal = "Manuel R Gutierrez #12",
                cp_fiscal = "91030",
                ciudad_fiscal = "Xalapa",
                estado_fiscal = "",
                nombre_alias = "",
                correo_fiscal = "",
                direccion = "",
                telefono = "",
                correo_contacto = ""
            };


            //Act
            provedorLogica.Insertar(provedor);

            //Assert
            Assert.AreNotEqual(provedor.rfc, null);
        }
        [TestMethod]
        public void InsertarProvedorMalNombre()
        {
            //Arrange
            var provedorLogica = new ProvedorLogica();
            var provedor = new Provedor()
            {
                rfc = "CEC941104AN5",
                razon_social = "COLEGIO DE ESTUDIOS CIENTIFICOS Y TECNOLOGICOS DEL ESTADO DE VERACRUZ",
                direccion_fiscal = "Manuel R Gutierrez #12",
                cp_fiscal = "91030",
                ciudad_fiscal = "Xalapa",
                estado_fiscal = "Veracruz",
                nombre_alias = "",
                correo_fiscal = "",
                direccion = "",
                telefono = "",
                correo_contacto = ""
            };


            //Act
            provedorLogica.Insertar(provedor);

            //Assert
            Assert.AreNotEqual(provedor.rfc, null);
        }
        [TestMethod]
        public void InsertarProvedorMalCorreo()
        {
            //Arrange
            var provedorLogica = new ProvedorLogica();
            var provedor = new Provedor()
            {
                rfc = "CEC941104AN5",
                razon_social = "COLEGIO DE ESTUDIOS CIENTIFICOS Y TECNOLOGICOS DEL ESTADO DE VERACRUZ",
                direccion_fiscal = "Manuel R Gutierrez #12",
                cp_fiscal = "91030",
                ciudad_fiscal = "Xalapa",
                estado_fiscal = "Veracruz",
                nombre_alias = "CECyTEV",
                correo_fiscal = "correo.com",
                direccion = "",
                telefono = "",
                correo_contacto = ""
            };


            //Act
            provedorLogica.Insertar(provedor);

            //Assert
            Assert.AreNotEqual(provedor.rfc, null);
        }
        [TestMethod]
        public void InsertarProvedorMalTelefono()
        {
            //Arrange
            var provedorLogica = new ProvedorLogica();
            var provedor = new Provedor()
            {
                rfc = "CEC941104AN5",
                razon_social = "COLEGIO DE ESTUDIOS CIENTIFICOS Y TECNOLOGICOS DEL ESTADO DE VERACRUZ",
                direccion_fiscal = "Manuel R Gutierrez #12",
                cp_fiscal = "91030",
                ciudad_fiscal = "Xalapa",
                estado_fiscal = "Veracruz",
                nombre_alias = "CECyTEV",
                correo_fiscal = "correo@hotmail.com",
                direccion = "",
                telefono = "228988312",
                correo_contacto = ""
            };


            //Act
            provedorLogica.Insertar(provedor);

            //Assert
            Assert.AreNotEqual(provedor.rfc, null);
        }
        [TestMethod]
        public void InsertarProvedorMalCorreo2()
        {
            //Arrange
            var provedorLogica = new ProvedorLogica();
            var provedor = new Provedor()
            {
                rfc = "CEC941104AN5",
                razon_social = "COLEGIO DE ESTUDIOS CIENTIFICOS Y TECNOLOGICOS DEL ESTADO DE VERACRUZ",
                direccion_fiscal = "Manuel R Gutierrez #12",
                cp_fiscal = "91030",
                ciudad_fiscal = "Xalapa",
                estado_fiscal = "Veracruz",
                nombre_alias = "CECyTEV",
                correo_fiscal = "correo@hotmail.com",
                direccion = "",
                telefono = "2289883126",
                correo_contacto = "fulano@correo"
            };


            //Act
            provedorLogica.Insertar(provedor);

            //Assert
            Assert.AreNotEqual(provedor.rfc, null);
        }
        [TestMethod]
        public void InsertarProvedorOK()
        {
            //Arrange
            var provedorLogica = new ProvedorLogica();
            var provedor = new Provedor()
            {
                rfc = "CEC941104AN5",
                razon_social = "COLEGIO DE ESTUDIOS CIENTIFICOS Y TECNOLOGICOS DEL ESTADO DE VERACRUZ",
                direccion_fiscal = "Manuel R Gutierrez #12",
                cp_fiscal = "91030",
                ciudad_fiscal = "Xalapa",
                estado_fiscal = "Veracruz",
                nombre_alias = "CECyTEV",
                correo_fiscal = "correo@hotmail.com",
                direccion = "",
                telefono = "2289883126",
                correo_contacto = "fulano@correo.com"
            };


            //Act
            provedorLogica.Insertar(provedor);

            //Assert
            Assert.AreNotEqual(provedor.rfc, null);
        }
    }
}
