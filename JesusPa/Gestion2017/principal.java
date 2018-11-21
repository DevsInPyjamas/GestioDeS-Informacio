public class principal {
    public static void main(String[] args) {
        // Abjejas en el sistema
        for (Abeja a : Abeja.ListaAbejas()) System.out.println(a);

        // Añado una nueva abeja
        Abeja nueva = new Abeja("Apis nova", "Nueva");

        // Muestro la Nueva
        System.out.println("La abjea nueva es:" + nueva);

        // Borro la Nueva
        System.out.println("La abjea nueva es:" + nueva);
        nueva.Borrar();

        // Busco la Borrada
        try {
            nueva = new Abeja("Apis nova");
            System.out.println("La abjea nueva es:" + nueva);
        } catch (Exception ex) {
            System.out.println("ERROR:" + ex.getMessage());
        }

        MuestraKilosMielAbeja(30000);
    }

    public static void MuestraKilosMielAbeja(int max) {

    }

}
