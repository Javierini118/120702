clc
%Funcion Polinomial, Grado 4 
f=@(x)x^4.*x^3-7.*x^2+13.*x+23.*-78;
%Gráfica  de la función x: [1,-7,+13+23-78]
fplot(f);
%Agregar Cuadrícula a la gráfica, título y nombre  a ejes
grid on; 
title   ("f(x)= x^4 -7 x^3 + 13 x^2 + 23 x - 78");
xlabel  ("x");
ylabel ("y");
%Encontrar los Ceros de la función
% Coeficientes  de la funcion f(x):
p=[1 -7 13 23 -78];
r=roots(p);
disp("los ceros de la función f(x) son:")
disp(r)