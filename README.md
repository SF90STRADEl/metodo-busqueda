# Algoritmos de Búsqueda en C#

**Autor:** Miguel Francisco Cortés Álvarez

## 🧭 Descripción General

Este proyecto tiene como objetivo implementar, comparar y analizar diferentes algoritmos clásicos de búsqueda utilizando el lenguaje de programación C#. Estos algoritmos son fundamentales para optimizar la localización de datos dentro de estructuras como arreglos o listas, especialmente en sistemas donde la eficiencia es clave.

### Algoritmos implementados:
- **Búsqueda Lineal:** Revisión secuencial de cada elemento hasta encontrar el valor buscado.
- **Búsqueda Binaria:** Divide iterativamente la estructura ordenada en mitades hasta ubicar el valor.
- **Búsqueda Exponencial:** Utiliza una fase de expansión rápida seguida de búsqueda binaria.
- **Búsqueda por Interpolación:** Estima la posición del valor basándose en su distribución en los datos.

---

## ⚙️ Requisitos y Configuración

### ✅ Requisitos del Sistema
- Lenguaje: **C#**
- IDE recomendado: **Visual Studio 2019 o superior**
- Framework: **.NET Framework 4.7.2 o superior**

---

## 🧰 Clonación y Ejecución

1. Clona este repositorio:
2. Abre la solución en Visual Studio: `Métodos de busqueda.sln`
3. Compila el proyecto: `Ctrl + Shift + B`
4. Ejecuta la aplicación: `F5` o selecciona *Iniciar depuración*

---

## 🧱 Estructura del Proyecto

Métodos-de-busqueda/
├── Métodos de busqueda.sln # Archivo de solución principal
├── Program.cs # Contiene la lógica de los algoritmos
└── README.md # Documentación del proyecto


---

## 🧠 Consideraciones Teóricas

| Algoritmo             | Mejor Caso | Peor Caso           | ¿Requiere datos ordenados? | Complejidad promedio |
|----------------------|------------|----------------------|-----------------------------|-----------------------|
| Búsqueda Lineal      | O(1)       | O(n)                | No                          | O(n)                 |
| Búsqueda Binaria     | O(1)       | O(log n)            | Sí                          | O(log n)             |
| Búsqueda Exponencial | O(log i)   | O(log i + log n)    | Sí                          | O(log n)             |
| Búsqueda Interpolación| O(1)      | O(n)                | Sí (distribución uniforme)  | O(log log n)         |

---

## 📌 Estado del Proyecto

- [x] Implementación de algoritmos
- [x] Interfaz por consola para pruebas
- [x] Documentación técnica
- [ ] Benchmarking con datos reales
- [ ] Visualización de resultados

---



## 🧾 Conclusión
Este proyecto proporciona una implementación sólida y clara de varios algoritmos clásicos de búsqueda en C#, sirviendo como una herramienta educativa y base funcional para análisis más avanzados. Al incluir tanto algoritmos sencillos como la búsqueda lineal, como otros más eficientes y especializados como la búsqueda exponencial e interpolación, se logra una visión integral del comportamiento y aplicabilidad de cada técnica.
La estructura modular del código permite comparar fácilmente el rendimiento de los algoritmos bajo distintas condiciones, lo cual es fundamental para entender sus fortalezas y limitaciones en escenarios reales. Aunque ya se cuenta con una interfaz funcional por consola y documentación técnica completa, se identifican áreas de mejora, especialmente en la incorporación de benchmarks con datos reales y visualización de resultados, que fortalecerán aún más el análisis empírico de eficiencia.
En resumen, este proyecto constituye una base excelente para profundizar en el estudio del rendimiento algorítmico, optimización de búsquedas y selección de estrategias según el contexto y las características de los datos.

