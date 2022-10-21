clc
%Funcion Polinomial, Grado 3 
f=@(x)x^3.*x^2-2.*x-3.*+2;
%Gráfica  de la función x: [25,-16]
fplot(f);
%Agregar Cuadrícula a la gráfica, título y nombre  a ejes
grid on; 
title   ("f(x)= x^3 -2x^2-3x +2");
xlabel  ("x");
ylabel ("y");
%Encontrar los Ceros de la función
% Coeficientes  de la funcion f(x):
p=[1 -2 -3 2];
r=roots(p);
disp("los ceros de la función f(x) son:")
disp(r)