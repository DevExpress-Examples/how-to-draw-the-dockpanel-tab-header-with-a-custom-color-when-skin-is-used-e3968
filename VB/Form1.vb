﻿Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            barAndDockingController1.PaintStyles.Add(New MyPaintStyle(barAndDockingController1.PaintStyles))
            barAndDockingController1.PaintStyleName = "MyPaintStyle"
        End Sub
    End Class
End Namespace
