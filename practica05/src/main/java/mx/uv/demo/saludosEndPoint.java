package mx.uv.demo;

import java.util.ArrayList;

import org.springframework.ws.server.endpoint.annotation.Endpoint;
import org.springframework.ws.server.endpoint.annotation.PayloadRoot;
import org.springframework.ws.server.endpoint.annotation.RequestPayload;
import org.springframework.ws.server.endpoint.annotation.ResponsePayload;

import mx.uv.t4is.saludos.BuscarSaludosResponse;
import mx.uv.t4is.saludos.SaludarRequest;
import mx.uv.t4is.saludos.SaludarResponse;
import mx.uv.t4is.saludos.BuscarSaludosResponse.Saludos;

@Endpoint
public class saludosEndPoint {
    ArrayList<Saludos> saludos = new ArrayList<>();

    @PayloadRoot(localPart = "SaludarRequest", namespace = "t4is.uv.mx/saludos")
    @ResponsePayload
    public SaludarResponse saludar(@RequestPayload SaludarRequest peticion){
        SaludarResponse respuesta = new SaludarResponse();
        respuesta.setRespuesta("Hola " + peticion.getNombre());
        Saludos e = new Saludos();
        e.setId(0);
        e.setNombre(peticion.getNombre());
        saludos.add(e);
        return respuesta;
    }

    @PayloadRoot(localPart = "BuscarSaludosRequest", namespace = "t4is.uv.mx/saludos")
    @ResponsePayload
    public BuscarSaludosResponse buscarSaludos(){
        BuscarSaludosResponse respuesta = new BuscarSaludosResponse();
        respuesta.getSaludos().addAll(saludos);
        return respuesta;
    }
}
