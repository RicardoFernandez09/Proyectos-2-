using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Llamar a los métodos para generar archivos XML
        CrearXMLConXmlWriter();
        CrearXMLConXmlDocument();
    }

    static void CrearXMLConXmlWriter()
    {
        string rutaArchivo = "contacts_writer.xml";

        using (XmlWriter writer = XmlWriter.Create(rutaArchivo))
        {
            // Iniciar documento XML
            writer.WriteStartDocument();
            writer.WriteStartElement("contacts");

            // Primer contacto
            writer.WriteStartElement("contact");
            writer.WriteAttributeString("phone", "123456789");
            writer.WriteString("Juan Pérez");
            writer.WriteEndElement();

            // Segundo contacto con otro atributo
            writer.WriteStartElement("contact");
            writer.WriteAttributeString("phone", "987654321");
            writer.WriteAttributeString("type", "work");
            writer.WriteString("Ana López");
            writer.WriteEndElement();

            // Cerrar nodo raíz y documento
            writer.WriteEndElement();
            writer.WriteEndDocument();
        }

        Console.WriteLine($"Archivo XML creado con XmlWriter: {rutaArchivo}");
    }

    static void CrearXMLConXmlDocument()
    {
        string rutaArchivo = "contacts_document.xml";

        XmlDocument xmlDoc = new XmlDocument();

        // Crear nodo raíz
        XmlElement root = xmlDoc.CreateElement("contacts");
        xmlDoc.AppendChild(root);

        // Primer contacto
        XmlElement contact1 = xmlDoc.CreateElement("contact");
        contact1.SetAttribute("phone", "123456789");
        contact1.InnerText = "Juan Pérez";
        root.AppendChild(contact1);

        // Segundo contacto
        XmlElement contact2 = xmlDoc.CreateElement("contact");
        contact2.SetAttribute("phone", "987654321");
        contact2.SetAttribute("type", "work");
        contact2.InnerText = "Ana López";
        root.AppendChild(contact2);

        // Guardar el archivo
        xmlDoc.Save(rutaArchivo);

        Console.WriteLine($"Archivo XML creado con XmlDocument: {rutaArchivo}");
    }
}
