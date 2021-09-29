namespace MetroAppComercial2021.Windows.Excepciones
{
    public static class GuiMessageManager
    {

        public static string ExistingRecord()
        {
            return "Registro existente... Operación denegada";
        }
        public static string NonRecordsAdded()
        {
            return "No se agregaron registros";
        }

        public static string RecordsAdded(int records)
        {
            return $"Se agregaron {records} registros";
        }
        public static string RecordsUpdated(int records)
        {
            return $"Se editaron {records} registros";
        }
        public static string RecordsDeleted(int records)
        {
            return $"Se borraron {records} registros";
        }

        public static string NonExistingOrModifiedRecord()
        {
            return "Registro borrado o modificado por otro usuario";
        }

        public static string RelatedRecords()
        {
            return "Registro relacionado... Baja denegada";
        }

        public static string ConfirmDelete()
        {
            return "¿Desea borrar el registro seleccionado?";
        }
    }
}
