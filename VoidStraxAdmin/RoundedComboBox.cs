using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedComboBox : ComboBox
{
    public int CornerRadius { get; set; } = 15; // Радиус закругления углов
    public Color BorderColor { get; set; } = Color.Gray; // Цвет границы
    public Color BackColorCustom { get; set; } = Color.White; // Цвет фона
    public int BorderThickness { get; set; } = 2; // Толщина границы

    public RoundedComboBox()
    {
        this.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
        this.BackColor = Color.DarkTurquoise;
        this.DrawMode = DrawMode.OwnerDrawFixed; // Устанавливаем режим отрисовки
        this.DropDownStyle = ComboBoxStyle.DropDownList; // Закрытый список (DropDown)
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Очищаем фон для предотвращения артефактов
        e.Graphics.Clear(Parent.BackColor);

        // Включаем антиалиасинг
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Создаем путь с закругленными углами
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90); // Верхний левый угол
            path.AddArc(this.Width - CornerRadius - 1, 0, CornerRadius, CornerRadius, 270, 90); // Верхний правый угол
            path.AddArc(this.Width - CornerRadius - 1, this.Height - CornerRadius - 1, CornerRadius, CornerRadius, 0, 90); // Нижний правый угол
            path.AddArc(0, this.Height - CornerRadius - 1, CornerRadius, CornerRadius, 90, 90); // Нижний левый угол
            path.CloseFigure();

            // Закрашиваем фон
            using (Brush brush = new SolidBrush(BackColorCustom))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Рисуем границу
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        // Проверка, чтобы избежать отрисовки индекса -1 (пустое состояние)
        if (e.Index < 0)
        {
            return;
        }

        e.DrawBackground();

        // Получаем цвет фона элемента в зависимости от его состояния
        bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
        Color itemBackColor = isSelected ? Color.LightBlue : BackColorCustom;
        Color itemForeColor = isSelected ? Color.Black : this.ForeColor;

        using (Brush backgroundBrush = new SolidBrush(itemBackColor))
        {
            e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
        }

        // Рисуем текст элемента
        using (Brush textBrush = new SolidBrush(itemForeColor))
        {
            e.Graphics.DrawString(this.Items[e.Index].ToString(), this.Font, textBrush, e.Bounds);
        }

        e.DrawFocusRectangle();
    }
}