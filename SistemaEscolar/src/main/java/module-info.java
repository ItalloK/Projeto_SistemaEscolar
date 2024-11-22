module hscorp.sistemaescolar {
    requires javafx.controls;
    requires javafx.fxml;


    opens hscorp.sistemaescolar to javafx.fxml;
    exports hscorp.sistemaescolar;
}