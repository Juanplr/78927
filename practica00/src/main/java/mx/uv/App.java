package mx.uv;

import static spark.Spark.*;

import com.fasterxml.jackson.dataformat.xml.XmlMapper;


public class App 
{
    public static void main( String[] args )
    {
        options("/*",(request,response)->{
            String accessControlRequestHeaders=request.headers("Access-Control-Request-Headers");
            if(accessControlRequestHeaders!=null){
            response.header("Access-Control-Allow-Headers",accessControlRequestHeaders);
            }
            String accessControlRequestMethod=request.headers("Access-Control-Request-Method");
            if(accessControlRequestMethod!=null){
            response.header("Access-Control-Allow-Methods",accessControlRequestMethod);
            }
            return "OK";
            });
        before((request,response)->response.header("Access-Control-Allow-Origin","*"));

        get("/", (request, response)->{
            String respuesta = "<note>\n" + //
                                "  <to>Tove</to>\n" + //
                                "  <from>Jani</from>\n" + //
                                "  <heading>Reminder</heading>\n" + //
                                "  <body>Don't forget me this weekend!</body>\n" + //
                                "</note>";
            response.type("application/xml");
            return respuesta;
        });
        get("/xml", (req, res)->{
            Alumno alumno = new Alumno();
            alumno.setNombre("Sebastian");
            alumno.setId("7");

            XmlMapper xml = new XmlMapper();
            String respuesta = xml.writeValueAsString(alumno);

            res.type("application/xml");
            //return "<nombre>" + alumno.getNombre() +"</nombre>";
            return respuesta;
        });
    }
}

class Alumno{
    String nombre;
    String apellido;
    String id;
    public String getNombre() {
        return nombre;
    }
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    public String getApellido() {
        return apellido;
    }
    public void setApellido(String apellido) {
        this.apellido = apellido;
    }
    public String getId() {
        return id;
    }
    public void setId(String id) {
        this.id = id;
    }
    
}
