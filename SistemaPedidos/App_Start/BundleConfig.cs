using System.Web;
using System.Web.Optimization;

namespace SistemaPedidos
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Content/vendor/jquery/jquery.min.js",
                     "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                     "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                     "~/Content/js/sb-admin-2.min.js",
                     "~/Content/vendor/chart.js/Chart.min.js",
                     "~/Content/js/demo/chart-area-demo.js",
                     "~/Content/js/demo/chart-pie-demo.js"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                     "~/Scripts/DataTables/jquery.dataTables.js",
                     "~/Scripts/DataTables/dataTables.tableTools.js",
                     "~/Scripts/DataTables/dataTables.scroller.min.js",
                     "~/Scripts/DataTables/dataTables.bootstrap.js"
                     ));
                     

            bundles.Add(new StyleBundle("~/Content/css").Include(                    
                      "~/Content/css/sb-admin-2.min.css",
                      "~/Content/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/DataTables/css/dataTables.bootstrap.css"));
        }
    }
}
