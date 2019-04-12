using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace library
{
	public class ENVehiculo
	{
        /// <summary>
        /// Atributo privado matricula
        /// </summary>
        private string matricula;
        /// <summary>
        /// Atributo privado marca
        /// </summary>
        private string marca;
        /// <summary>
        /// Atributo privado modelo
        /// </summary>
        private string modelo;
        /// <summary>
        /// Atributo privado color
        /// </summary>
        private string color;
        /// <summary>
        /// Atributo privado combustible
        /// </summary>
        private float combustible;
        /// <summary>
        /// Atributo privado año
        /// </summary>
        private int año;
        /// <summary>
        /// Atributo privado kilometros
        /// </summary>
        private float kilometros;
        /// <summary>
        /// Atributo privado precio
        /// </summary>
        private float precio;
        /// <summary>
        /// Atributo privado potencia
        /// </summary>
        private int potencia;
        /// <summary>
        /// Propiedad pública de matricula
        /// </summary>
        public string matriculaVehiculo
        {
            get { return matricula;  }
            set { matricula = value; }
        }
        /// <summary>
        /// Propiedad pública de marca
        /// </summary>
        public string marcaVehiculo
        {
            get { return marca; }
            set { marca = value; }
        }
        /// <summary>
        /// Propiedad pública de modelo
        /// </summary>
        public string modeloVehiculo
        {
            get { return modelo;  }
            set { modelo = value; }
        }
        /// <summary>
        /// Propiedad pública de color
        /// </summary>
        public string colorVehiculo
        {
            get { return color; }
            set { color = value; }
        }
        /// <summary>
        /// Propiedad pública de combustible
        /// </summary>
        public float combustibleVehiculo
        {
            get { return combustible; }
            set { combustible = value; }
        }
        /// <summary>
        /// Propiedad pública de año
        /// </summary>
        public int añoVehiculo
        {
            get { return año; }
            set { año = value; }
        }
        /// <summary>
        /// Propiedad pública de kilometros
        /// </summary>
        public float kilometrosVehiculo
        {
            get { return kilometros; }
            set { kilometros = value; }
        }
        /// <summary>
        /// Propiedad pública de precio
        /// </summary>
        public float precioVehiculo
        {
            get { return precio; }
            set { precio = value; }
        }
        /// <summary>
        /// Propiedad pública de potencia
        /// </summary>
        public int potenciaVehiculo
        {
            get { return potencia; }
            set { potencia = value; }
        }
	}
}
