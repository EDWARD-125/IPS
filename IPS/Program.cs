using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;

namespace IPS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
             Guardar(service);
            ////   Eliminar();
              ConsultaGeneral(service);
           // Modificar(service);
        }

        private static void Guardar(LiquidacionCuotaModeradoraService service)
        {
            string numeroLiquidacion, identificacion, nombre, tipoAfiliacion;
            double salarioDevengado, valorServicioHospitalizacion;
            Console.Write("Digite numero de liquidacion: ");
            numeroLiquidacion = Console.ReadLine();

            Console.Write("Digite identificacion: ");
            identificacion = Console.ReadLine();

            Console.Write("Digite nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Digite tipo de afiliacion: ");
            tipoAfiliacion = Console.ReadLine();

            Console.Write("Digite salario devengado: ");
            salarioDevengado = double.Parse(Console.ReadLine());

            Console.Write("Digite valor servicio de hospitalizacion: ");
            valorServicioHospitalizacion = double.Parse(Console.ReadLine());

            LiquidacionCuotaModeradora liquidacion = new LiquidacionCuotaModeradora()
            {
                NumeroLiquidacion = numeroLiquidacion,
                Identificacion = identificacion,
                Nombre = nombre,
                TipoAfiliacion = tipoAfiliacion,
                SalarioDevengado = salarioDevengado,
                ValorServicioHospitalizacion = valorServicioHospitalizacion
            };

            service.calcular(liquidacion);
            string mensaje=service.Guardar(liquidacion);
            Console.Write(mensaje);
            Console.WriteLine(liquidacion.ToString());
            Console.ReadKey();
        }

        public static void Eliminar()
        {
            Console.Clear();
            Console.WriteLine("ELIMINAR");
            LiquidacionCuotaModeradora liquidacion = new LiquidacionCuotaModeradora();
            LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
            Console.Write("Digite numero de liquidacion a eliminar: ");
            string numeroLiquidacion;
            numeroLiquidacion = Console.ReadLine();
            string mensaje = service.Eliminar(numeroLiquidacion);
            Console.WriteLine(mensaje);
            Console.ReadKey();
            Console.Clear();
        }

        private static void ConsultaGeneral(LiquidacionCuotaModeradoraService service)
        {
            Console.Clear();
            RespuestaConsulta respuestaConsulta = service.ConsultarConsultaGeneral();
            Console.WriteLine(respuestaConsulta.Mensaje);
            if (!respuestaConsulta.Error)
            {
                foreach (var item in respuestaConsulta.liquidaciones)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        //        private static void Modificar(LiquidacionCuotaModeradoraService service)
        //        {
        //            // Console.Clear();
        //            LiquidacionCuotaModeradora liquidacion1 = new LiquidacionCuotaModeradora()
        //;
        //            string numeroLiquidacion, identificacion, nombre, tipoAfiliacion, tope;
        //            double valorServicioHospitalizacion, salarioDevengado, cuotaModeradora, tarifa;
        //            nombre=liquidacion1.Nombre.ToString();
        //            identificacion = liquidacion1.Identificacion.ToString();
        //            tipoAfiliacion = liquidacion1.TipoAfiliacion.ToString();
        //            salarioDevengado = double.Parse(liquidacion1.SalarioDevengado.ToString());
        //            cuotaModeradora = double.Parse(liquidacion1.CuotaModeradora.ToString());
        //            tarifa = double.Parse(liquidacion1.Tarifa.ToString());
        //            tope = liquidacion1.Tope.ToString();
        //            Console.WriteLine("\t\t\tMODIFICAR UNA LIQUIDACION");
        //            Console.Write("\t\t\tDigite numero de liquidacion: ");
        //            numeroLiquidacion = Console.ReadLine();
        //            Console.Write("\t\t\tDigite valor: ");
        //            valorServicioHospitalizacion = double.Parse(Console.ReadLine());

        //            LiquidacionCuotaModeradora liquidacion = new LiquidacionCuotaModeradora()
        //            {
        //                NumeroLiquidacion = numeroLiquidacion.ToString(),
        //                Identificacion = identificacion.ToString(),
        //                Nombre=nombre.ToString(),
        //                TipoAfiliacion=tipoAfiliacion.ToString(),
        //                SalarioDevengado=double.Parse(salarioDevengado.ToString()),
        //                ValorServicioHospitalizacion = double.Parse(valorServicioHospitalizacion.ToString()),
        //                CuotaModeradora=double.Parse(cuotaModeradora.ToString()),
        //                Tarifa=double.Parse(tarifa.ToString()),
        //                Tope=tope.ToString()
        //            };
        //            service.calcular(liquidacion);
        //            string mensaje = service.Modificar(liquidacion);
        //            Console.WriteLine(mensaje);
        //            Console.ReadKey();
        //            Console.Clear();
        //        }

        private static void Modificar(LiquidacionCuotaModeradoraService service)
        {
            // Console.Clear();
           
            Console.WriteLine("\t\t\tMODIFICAR UNA LIQUIDACION");
            Console.Write("\t\t\tDigite numero de liquidacion: ");
            string numeroLiquidacion;
            double valorServicioHospitalizacion;
            numeroLiquidacion = Console.ReadLine();
            Console.Write("\t\t\tDigite valor: ");
            valorServicioHospitalizacion = double.Parse(Console.ReadLine());

            LiquidacionCuotaModeradora liquidacion = new LiquidacionCuotaModeradora()
            {
                NumeroLiquidacion = numeroLiquidacion,
                
                ValorServicioHospitalizacion = valorServicioHospitalizacion
               
            };
            service.calcular(liquidacion);
            string mensaje = service.Modificar(liquidacion);
            Console.WriteLine(mensaje);
            Console.ReadKey();
            Console.Clear();
        }

    }
}
