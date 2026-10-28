Algoritmo LaboratorioSistemaDeCalificaciones
	
	Definir nombre, condicion, entrada, clasificacion Como Caracter
	Definir calificacion Como Real
	
	Escribir "============================================"
	Escribir "=== Sistema de Calificaciones Académicas ==="
	Escribir "============================================"
	
	Escribir "Nombre del estudiante: "
	Leer nombre
	
	Escribir "Calificación (0 - 100): "
	Leer calificacion
	// RN-08: la validación numérica la hace decimal.TryParse() en C#.
	// PSeInt no puede validarla sin ciclos; si se ingresa texto, PSeInt detiene la ejecución.
	
	// RN-01
		Si calificacion < 0 o calificacion > 100 Entonces
			Escribir "Error: nota fuera de rango (0-100)."
		SiNo
			// RN-02 a RN-05 (de mayor a menor, sin condiciones redundantes)
			Si calificacion >= 90 Entonces
				clasificacion <- "Excelente"
			SiNo
				Si calificacion >= 80 Entonces
					clasificacion <- "Muy bueno"
				SiNo
					Si calificacion >= 70 Entonces
						clasificacion <- "Aprobado"
					SiNo
						clasificacion <- "Reprobado"
					FinSi
				FinSi
			FinSi
			// RN-06 / RN-07
			Si calificacion >= 70 Entonces
				condicion <- "Aprobado"
			SiNo
				condicion <- "Reprobado"
			FinSi
			Escribir "=== RESUMEN ACADÉMICO ==="
			Escribir "Estudiante: ", nombre
			Escribir "Nota: ", calificacion
			Escribir "Clasificación: ", clasificacion
			Escribir "Condición Académica: ", condicion
		FinSi
FinAlgoritmo
	