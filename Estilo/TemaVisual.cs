using System.Drawing.Text;
using System.Reflection;

namespace GestionAcademica.Estilo
{
    public static class TemaVisual
    {
        public static readonly Color Azul = Color.FromArgb(27, 54, 93);
        public static readonly Color AzulHover = Color.FromArgb(36, 70, 122);
        public static readonly Color AzulAcento = Color.FromArgb(42, 90, 155);
        public static readonly Color Fondo = Color.FromArgb(241, 245, 249);
        public static readonly Color Borde = Color.FromArgb(203, 213, 225);
        public static readonly Color Texto = Color.FromArgb(30, 41, 59);
        public static readonly Color TextoSuave = Color.FromArgb(71, 85, 105);
        public static readonly Color Peligro = Color.FromArgb(220, 38, 38);
        public static readonly Color PeligroSuave = Color.FromArgb(254, 226, 226);
        public static readonly Color Neutro = Color.FromArgb(226, 232, 240);
        public static readonly Color NeutroHover = Color.FromArgb(203, 213, 225);
        public static readonly Color FilaAlterna = Color.FromArgb(248, 250, 252);
        public static readonly Color Seleccion = Color.FromArgb(219, 234, 254);

        public static void Aplicar(Form formulario)
        {
            formulario.BackColor = Fondo;
            AplicarAControles(formulario.Controls);
        }

        private static void AplicarAControles(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is Button boton) EstilizarBoton(boton);
                else if (control is DataGridView tabla) EstilizarTabla(tabla);
                else if (control is TabControl pestanas) EstilizarPestanas(pestanas);
                else if (control is TabPage pagina) pagina.BackColor = Fondo;
                else if (control is Panel panel) EstilizarPanel(panel);
                else if (control is Label etiqueta) EstilizarEtiqueta(etiqueta);

                if (control.HasChildren)
                    AplicarAControles(control.Controls);
            }
        }
        private static void EstilizarBoton(Button boton)
        {
            string texto = (boton.Text ?? string.Empty).Trim().ToLowerInvariant();

            boton.FlatStyle = FlatStyle.Flat;
            boton.UseVisualStyleBackColor = false;
            boton.Cursor = Cursors.Hand;

            if (texto.Contains("eliminar") || texto == "cancelar")
                Contorno(boton, Peligro, PeligroSuave);
            else if (texto.Contains("agregar") || texto.Contains("guardar") || texto.Contains("ingresar")
                     || texto.Contains("iniciar") || texto.Contains("generar"))
                Relleno(boton, Azul, AzulHover, Color.White);
            else if (texto.Contains("editar") || texto.Contains("modificar") || texto.Contains("actualizar"))
                Contorno(boton, Azul, Seleccion);
            else if (texto.Contains("buscar"))
                Relleno(boton, AzulAcento, Color.FromArgb(30, 72, 130), Color.White);
            else
                Relleno(boton, Neutro, NeutroHover, Texto);
        }

        private static void Relleno(Button boton, Color fondo, Color hover, Color texto)
        {
            boton.BackColor = fondo;
            boton.ForeColor = texto;
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatAppearance.MouseOverBackColor = hover;
            boton.FlatAppearance.MouseDownBackColor = hover;
        }

        private static void Contorno(Button boton, Color color, Color hover)
        {
            boton.BackColor = Color.White;
            boton.ForeColor = color;
            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.BorderColor = color;
            boton.FlatAppearance.MouseOverBackColor = hover;
            boton.FlatAppearance.MouseDownBackColor = hover;
        }
        
        private static void EstilizarTabla(DataGridView tabla)
        {
            tabla.EnableHeadersVisualStyles = false;
            tabla.BorderStyle = BorderStyle.None;
            tabla.BackgroundColor = Color.White;
            tabla.GridColor = Color.FromArgb(226, 232, 240);
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tabla.ColumnHeadersHeight = 36;
            tabla.RowHeadersVisible = false;
            tabla.RowTemplate.Height = 30;

            DataGridViewCellStyle encabezado = tabla.ColumnHeadersDefaultCellStyle;
            encabezado.BackColor = Azul;
            encabezado.ForeColor = Color.White;
            encabezado.SelectionBackColor = Azul;
            encabezado.SelectionForeColor = Color.White;
            encabezado.Font = new Font(tabla.Font, FontStyle.Bold);
            encabezado.Padding = new Padding(6, 0, 6, 0);
            encabezado.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DataGridViewCellStyle celdas = tabla.DefaultCellStyle;
            celdas.BackColor = Color.White;
            celdas.ForeColor = Texto;
            celdas.SelectionBackColor = Seleccion;
            celdas.SelectionForeColor = Texto;
            celdas.Padding = new Padding(6, 0, 6, 0);

            DataGridViewCellStyle alternas = tabla.AlternatingRowsDefaultCellStyle;
            alternas.BackColor = FilaAlterna;
            alternas.ForeColor = Texto;
            alternas.SelectionBackColor = Seleccion;
            alternas.SelectionForeColor = Texto;

            
            typeof(DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                ?.SetValue(tabla, true, null);
        }

        
        private static void EstilizarPestanas(TabControl pestanas)
        {
            Font normal = new Font("Segoe UI", 9.5F);
            Font negrita = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            pestanas.DrawMode = TabDrawMode.OwnerDrawFixed;
            pestanas.SizeMode = TabSizeMode.Fixed;
            pestanas.ItemSize = new Size(Math.Max(pestanas.ItemSize.Width, 260), 36);

            pestanas.DrawItem += (sender, e) =>
            {
                bool activa = e.Index == pestanas.SelectedIndex;
                using (SolidBrush fondo = new SolidBrush(activa ? Azul : Neutro))
                    e.Graphics.FillRectangle(fondo, e.Bounds);

                TextRenderer.DrawText(e.Graphics, pestanas.TabPages[e.Index].Text, activa ? negrita : normal,
                    e.Bounds, activa ? Color.White : TextoSuave,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
        }

       
       
        private static void EstilizarPanel(Panel panel)
        {
            if (panel.Dock != DockStyle.None || panel.BackColor.ToArgb() != Color.White.ToArgb())
                return;

            panel.Paint += (sender, e) =>
            {
                using (Pen lapiz = new Pen(Borde))
                    e.Graphics.DrawRectangle(lapiz, 0, 0, panel.Width - 1, panel.Height - 1);
            };
        }

        private static void EstilizarEtiqueta(Label etiqueta)
        {
            
            if (etiqueta.ForeColor.ToArgb() == SystemColors.ControlText.ToArgb())
                etiqueta.ForeColor = Color.FromArgb(51, 65, 85);
        }

        
        public const string FuenteIconos = "Segoe MDL2 Assets";

        public static Bitmap CrearIcono(string glifo, Color color, int tamano = 20, int margenDerecho = 12)
        {
            Bitmap imagen = new Bitmap(tamano + margenDerecho, tamano);
            using (Graphics g = Graphics.FromImage(imagen))
            using (Font fuente = new Font(FuenteIconos, tamano * 0.8F, FontStyle.Regular, GraphicsUnit.Pixel))
            using (SolidBrush pincel = new SolidBrush(color))
            using (StringFormat formato = new StringFormat())
            {
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                formato.Alignment = StringAlignment.Center;
                formato.LineAlignment = StringAlignment.Center;
                g.DrawString(glifo, fuente, pincel, new RectangleF(0, 0, tamano, tamano), formato);
            }
            return imagen;
        }
    }
}
