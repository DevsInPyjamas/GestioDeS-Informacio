import java.sql.Date;
import java.time.LocalDate;

public class mainP4 {

    public static void main(String[] args) {
        for (Paciente p : Paciente.ListaPacientes()) {
            System.out.println(p);
            Cita cx = new Cita(p.getNumeroSS_Paciente(), Date.valueOf(LocalDate.now())
                    , "Prueba");

            for (Cita c : p.getCitas()) System.out.println("\t" + c);
        }

    }

}
