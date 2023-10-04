namespace lesson17_practice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Car kia = new Car("Kia", 45, 50);
            Car porsche = new Car("porsche", 45, 50);
            Car lada = new Car("lada", 45, 50);
            Car toyota = new Car("toyota", 60, 50);


            kia.GetinfoCar();

            Gallery best_cars_gallery=new Gallery();
            best_cars_gallery.AddCar(kia);
            best_cars_gallery.AddCar(porsche);
            best_cars_gallery.AddCar(lada);
            best_cars_gallery.AddCar(toyota);

            Console.WriteLine("****************************");
            best_cars_gallery.GetGalleryCarShow();

            best_cars_gallery.SumCar();

            best_cars_gallery.DeleteCar(2);
            Console.WriteLine("****************************");

            best_cars_gallery.GetGalleryCarShow();
            best_cars_gallery.ShowCarForSpeed(30, 50);


        }
    }
}