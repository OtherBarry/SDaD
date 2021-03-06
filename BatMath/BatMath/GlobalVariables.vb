﻿Module GlobalVariables
    Public Area As Boolean
    Public ShapeNum As Integer
    Public Shapes2D() = {"Circle", "Square", "Triangle", "Hexagon", "Pentagon", "Rectangle"}
    Public Shapes3D() = {"Sphere", "Cube", "Cone", "Pyramid", "Prism", "Cylinder"}
    Public AreaVal As Decimal
    Public Volume As Decimal
    Public pi As Decimal = 3.14159265
    Public questionNumber As Integer = 0
    Public correctNumber As Integer = 0
    Public RadioButtonsArea() As RadioButton = {screenQuiz.RadioButton1, screenQuiz.RadioButton2, screenQuiz.RadioButton3, screenQuiz.RadioButton4}
    Public RadioButtonsVolume() As RadioButton = {screenQuizVolume.RadioButton1, screenQuizVolume.RadioButton2, screenQuizVolume.RadioButton3, screenQuizVolume.RadioButton4}
    Public random As Integer
    Public QuestionsArea() = {"What is the formula for the area of a circle?", "What is the formula for the area of a square?", "What is the formula for the area of a triangle?", "What is the formula for the area of a hexagon?", "What is the formula for the area of a pentagon?", "What is the formula for the area of a rectangle?", "What is pi?"}
    Public QuestionsVol() = {"What is the formula for the volume of a sphere?", "What is the formula for the area of a  cube?", "What is the formula for the area of a cone?", "What is the formula for the area of a pyramid?", "What is the formula for the area of a rectangular prism?", "What is the formula for the area of a cylinder?", "What is pi?"}
    Public AnswersArea(,) = {{"pi × radius²", "side²", "½ × base × height", "2.6 × side²", "1.72 × side²", "length × height", "The ratio of a circle's" & vbCrLf & "radius to it's diameter."},
                             {"pi × radius", "side³", "base × height", "2.6 × side", "1.72 × side", "½ × length × height", "The ratio of a circle's" & vbCrLf & "circumeference to it's radius."},
                             {"pi × radius³", "side", "2 × base × height", "2.6² × side", "1.72² × side", "2 × length × height", "The ratio of apples to" & vbCrLf & "pastry in an apple pie"},
                             {"pi² × radius", "pi × side", "pi × base × height", "pi × 2.6 × side²", "pi × 1.72 × side²", "pi × length × height", "The ratio of a circle's" & vbCrLf & "circumeference to it's diameter."}}
    Public AnswersVolume(,) = {{"(4 × pi × radius³) ÷ 3", "side³", "(pi × radius² × height) ÷ 3", "(length × width × height) ÷ 3", "length × width × height", "pi × radius² × height", "The ratio of a circle's" & vbCrLf & "radius to it's diameter."},
                               {"(4 × pi × radius²) ÷ 3", "side²", "(pi × radius³ × height) ÷ 3", "(width × height) ÷ 3", "length × height", "radius² × height", "The ratio of a circle's" & vbCrLf & "radius to it's diameter."},
                               {"(4 × pi × radius³)", "side", "(pi × radius × height) ÷ 3", "(length  × height) ÷ 3", "length × width ", "pi × radius³ × height", "The ratio of a circle's" & vbCrLf & "radius to it's diameter."},
                               {"(pi × radius²) ÷ 3", "side × pi", "(radius² × height) ÷ 3", "(length × width) ÷ 3", "width × height", "pi × radius × height", "The ratio of a circle's" & vbCrLf & "radius to it's diameter."}}
End Module
