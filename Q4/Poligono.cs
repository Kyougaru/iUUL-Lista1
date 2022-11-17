using System;
using System.Collections.Generic;
using Q2;

namespace Q4
{
    class Poligono
    {
        private List<Vertice> vertices;

        public int qtdVertices
        {
            get { return vertices.Count; }
        }

        public Poligono(Vertice[] vertices)
        {
            this.vertices = new List<Vertice>();

            foreach (Vertice v in vertices) { 
                this.vertices.Add(v); 
            }

            EhPoligono();
        }

        public bool AddVertice(Vertice vertice)
        {
            foreach (Vertice v in vertices) {
                if (v.Equals(vertice))
                {
                    return false;
                }
            }

            vertices.Add(vertice);

            return true;
        }

        public bool RemoveVertice(Vertice vertice)
        {
            foreach (Vertice v in vertices)
            {
                if (v.Equals(vertice))
                {
                    vertices.Remove(vertice);
                    EhPoligono();

                    return true;
                }
            }

            return false;
        }

        private void EhPoligono()
        {
            if (vertices.Count < 3)
            {
                throw new Exception("Você não pode criar um poligono com menos de 3 vertices !");
            }
        }
    }
}
