namespace SimuladorNavegadorWeb
{
    public partial class Form1 : Form
    {
        // Dos pilas principales para gestionar el historial de navegación
        private Stack<string> pilaAtras = new Stack<string>();
        private Stack<string> pilaAdelante = new Stack<string>();
        private string paginaActual = "";

        public Form1()
        {
            InitializeComponent();
            ActualizarInterfaz();
        }
        // Evento: Botón Visitar
        private void btnVisitar_Click(object sender, EventArgs e)
        {
            string nuevaUrl = txtUrl.Text.Trim();

            if (!string.IsNullOrEmpty(nuevaUrl))
            {
                // Si ya había una página actual, se guarda en la pila de Atrás
                if (!string.IsNullOrEmpty(paginaActual))
                {
                    pilaAtras.Push(paginaActual);
                }

                paginaActual = nuevaUrl;

                // Al visitar una nueva página, la pila de Adelante se limpia por completo
                pilaAdelante.Clear();

                txtUrl.Clear();
                ActualizarInterfaz();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una URL válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Evento: Botón Atrás
        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (pilaAtras.Count > 0)
            {
                // La página actual se pasa a la pila de Adelante
                pilaAdelante.Push(paginaActual);

                // La nueva página actual es la cima de la pila de Atrás (Pop)
                paginaActual = pilaAtras.Pop();

                ActualizarInterfaz();
            }
        }
        // Evento: Botón Adelante
        private void btnAdelante_Click(object sender, EventArgs e)
        {
            if (pilaAdelante.Count > 0)
            {
                // La página actual se regresa a la pila de Atrás
                pilaAtras.Push(paginaActual);

                // La nueva página actual se extrae de la pila de Adelante (Pop)
                paginaActual = pilaAdelante.Pop();

                ActualizarInterfaz();
            }
        }

        // Método auxiliar para refrescar controles visuales y estado de los botones
        private void ActualizarInterfaz()
        {
            // Actualizar etiqueta de página actual
            lblPaginaActual.Text = string.IsNullOrEmpty(paginaActual)
                ? "Página actual: (Ninguna)"
                : $"Página actual: {paginaActual}";

            // Habilitar o deshabilitar botones según la disponibilidad en las pilas
            btnAtras.Enabled = pilaAtras.Count > 0;
            btnAdelante.Enabled = pilaAdelante.Count > 0;

            // Mostrar el contenido actual de la Pila de Atrás
            lstHistorialAtras.Items.Clear();
            foreach (string url in pilaAtras)
            {
                lstHistorialAtras.Items.Add(url);
            }

            // Mostrar el contenido actual de la Pila de Adelante
            lstHistorialAdelante.Items.Clear();
            foreach (string url in pilaAdelante)
            {
                lstHistorialAdelante.Items.Add(url);
            }
        }
    }
}
