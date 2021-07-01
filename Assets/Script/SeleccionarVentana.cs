using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SeleccionarVentana : MonoBehaviour
{
    public GameObject VentanaAsiento;
    public GameObject VentanaGasolina;
    public GameObject VentanaChasis;
    public GameObject VentanaNeumaticos;
    public GameObject VentanaCasco;
    public GameObject VentanaGuardabarros;
    public GameObject VentanaEscape;
    public GameObject VentanaSuspencion;
    public GameObject VentanaCupula;

    Animation AVentanaAsiento;
    Animation AVentanaGasolina;
    Animation AVentanaChasis;
    Animation AVentanaNeumaticos;
    Animation AVentanaCasco;
    Animation AVentanaGuardabarros;
    Animation AVentanaEscape;
    Animation AVentanaSuspencion;
    Animation AVentanaCupula;

    bool VisibleAsiento = false;
    bool VisibleGasolina = false;
    bool VisibleChasis = false;
    bool VisibleNeumaticos = false;
    bool VisibleCasco = false;
    bool VisibleGuardabarros = false;
    bool VisibleEscape = false;
    bool VisibleSuspencion = false;
    bool VisibleCupula = false;
    
    void Start()
    {
        AVentanaAsiento = VentanaAsiento.GetComponent<Animation>();
        AVentanaGasolina = VentanaGasolina.GetComponent<Animation>();
        AVentanaChasis = VentanaChasis.GetComponent<Animation>();
        AVentanaNeumaticos= VentanaNeumaticos.GetComponent<Animation>();
        AVentanaCasco = VentanaCasco.GetComponent<Animation>();
        AVentanaGuardabarros = VentanaGuardabarros.GetComponent<Animation>();
        AVentanaEscape = VentanaEscape.GetComponent<Animation>();
        AVentanaSuspencion = VentanaSuspencion.GetComponent<Animation>();
        AVentanaCupula = VentanaCupula.GetComponent<Animation>();
    }
    public void Ventana1Pulsada()
    {
        if (VisibleAsiento == false)
        {
            AVentanaAsiento["Asiento"].speed = 1;
            AVentanaAsiento.Play();
            VisibleAsiento = true;
        }
    }
    public void Ventana2Pulsada()
    {
        if (VisibleGasolina == false)
        {
            AVentanaGasolina["Gasolina"].speed = 1;
            AVentanaGasolina.Play();
            VisibleGasolina = true;
        }
    }
       public void Ventana3Pulsada()
    {
        if (VisibleChasis == false)
        {
            AVentanaChasis["Chasis"].speed = 1;
            AVentanaChasis.Play();
            VisibleChasis = true;
        }
    }
       public void Ventana4Pulsada()
    {
        if (VisibleNeumaticos == false)
        {
            AVentanaNeumaticos["Neumaticos"].speed = 1;
            AVentanaNeumaticos.Play();
            VisibleNeumaticos = true;
        }
    }
       public void Ventana5Pulsada()
    {
        if (VisibleCasco == false)
        {
            AVentanaCasco["Casco"].speed = 1;
            AVentanaCasco.Play();
            VisibleCasco = true;
        }
    }
       public void Ventana6Pulsada()
    {
        if (VisibleGuardabarros == false)
        {
            AVentanaGuardabarros["Guardabarros"].speed = 1;
            AVentanaGuardabarros.Play();
            VisibleGuardabarros = true;
        }
    }
       public void Ventana7Pulsada()
    {
        if (VisibleEscape == false)
        {
            AVentanaEscape["Escape"].speed = 1;
            AVentanaEscape.Play();
            VisibleEscape = true;
        }
    }
       public void Ventana8Pulsada()
    {
        if (VisibleSuspencion == false)
        {
            AVentanaSuspencion["Suspension"].speed = 1;
            AVentanaSuspencion.Play();
            VisibleSuspencion = true;
        }
    }
       public void Ventana9Pulsada()
    {
        if (VisibleCupula == false)
        {
            AVentanaCupula["Cupula"].speed = 1;
            AVentanaCupula.Play();
            VisibleCupula = true;
        }
    }
    public void VentanaNoPulsada()
    {
        string NombreBoton = EventSystem.current.currentSelectedGameObject.name;

        if (NombreBoton != "Asiento" & VisibleAsiento == true)
        {
            
            AVentanaAsiento["Asiento"].time = AVentanaAsiento["Asiento"].length;
            AVentanaAsiento.Play();
            VisibleAsiento = false;
        }

        if (NombreBoton != "Gasolina" & VisibleGasolina == true)
        {
            
            AVentanaGasolina["Gasolina"].time = AVentanaGasolina["Gasolina"].length;
            AVentanaGasolina.Play();
            VisibleGasolina = false;
        }

        if (NombreBoton != "Chasis" & VisibleChasis == true)
        {
            
            AVentanaChasis["Chasis"].time = AVentanaChasis["Chasis"].length;
            AVentanaChasis.Play();
            VisibleChasis = false;
        }

        if (NombreBoton != "Neumaticos" & VisibleNeumaticos == true)
        {
            
            AVentanaNeumaticos["Neumaticos"].time = AVentanaNeumaticos["Neumaticos"].length;
            AVentanaNeumaticos.Play();
            VisibleNeumaticos = false;
        }

        if (NombreBoton != "Casco" & VisibleCasco == true)
        {
            
            AVentanaCasco["Casco"].time = AVentanaCasco["Casco"].length;
            AVentanaCasco.Play();
            VisibleCasco = false;
        }

        if (NombreBoton != "Guardabarros" & VisibleGuardabarros == true)
        {
            
            AVentanaGuardabarros["Guardabarros"].time = AVentanaGuardabarros["Guardabarros"].length;
            AVentanaGuardabarros.Play();
            VisibleGuardabarros = false;
        }

        if (NombreBoton != "Escape" & VisibleEscape == true)
        {
            
            AVentanaEscape["Escape"].time = AVentanaEscape["Escape"].length;
            AVentanaEscape.Play();
            VisibleEscape = false;
        }

        if (NombreBoton != "Suspension" & VisibleSuspencion == true)
        {
            
            AVentanaSuspencion["Suspension"].time = AVentanaSuspencion["Suspension"].length;
            AVentanaSuspencion.Play();
            VisibleSuspencion = false;
        }

        if (NombreBoton != "Cupula" & VisibleCupula == true)
        {
            
            AVentanaCupula["Cupula"].time = AVentanaCupula["Cupula"].length;
            AVentanaCupula.Play();
            VisibleCupula = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
