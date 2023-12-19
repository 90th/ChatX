using System;
using System.Drawing;
using System.Windows.Forms;

public class FormDragHandler {
    private readonly Control control;
    private Point dragCursorPoint;
    private Point dragFormPoint;
    private bool dragging;
    private Form form;

    public FormDragHandler(Control control, Form form) {
        this.control = control;
        this.form = form;

        control.MouseDown += Control_MouseDown;
        control.MouseMove += Control_MouseMove;
        control.MouseUp += Control_MouseUp;

        if (form != null) {
            form.MouseDown += Form_MouseDown;
            form.MouseMove += Form_MouseMove;
            form.MouseUp += Form_MouseUp;
        }
    }

    private void Control_MouseDown(object sender, MouseEventArgs e) {
        StartDragging();
    }

    private void Control_MouseMove(object sender, MouseEventArgs e) {
        HandleDrag();
    }

    private void Control_MouseUp(object sender, MouseEventArgs e) {
        StopDragging();
    }

    private void Form_MouseDown(object sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left && e.Clicks == 1 && e.Y <= control.Height) {
            StartDragging();
        }
    }

    private void Form_MouseMove(object sender, MouseEventArgs e) {
        HandleDrag();
    }

    private void Form_MouseUp(object sender, MouseEventArgs e) {
        StopDragging();
    }

    private void HandleDrag() {
        if (dragging) {
            Point difference = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
            form.Location = Point.Add(dragFormPoint, new Size(difference));
        }
    }

    private void StartDragging() {
        dragging = true;
        dragCursorPoint = Cursor.Position;
        dragFormPoint = form.Location;

        form.Opacity = 0.7;
    }

    private void StopDragging() {
        dragging = false;

        form.Opacity = 1.0;
    }
}