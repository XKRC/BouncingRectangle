using System;

public class Matrix3x3
{
    double a11, a12, a13, a21, a22, a23, a31, a32, a33;

    public Matrix3x3()
	{
        a11 = 0;
        a12 = 0;
        a13 = 0;
        a21 = 0;
        a22 = 0;
        a23 = 0;
        a31 = 0;
        a32 = 0;
        a33 = 0;
	}

    public Matrix3x3(double a11, double a12, double a13, double a21, double a22, double a23, double a31, double a32, double a33)
    {
        this.a11 = a11;
        this.a12 = a12;
        this.a13 = a13;
        this.a21 = a21;
        this.a22 = a22;
        this.a23 = a23;
        this.a31 = a31;
        this.a32 = a32;
        this.a33 = a33;
    }

    Matrix3x3 times(Matrix3x3 m)
    {
        return new Matrix3x3(this.a11 * m.a11 + this.a12 * m.a21 + this.a13 * m.a31, this.a11 * m.a12 + this.a12 * m.a22 + this.a13 * m.a32, this.a11 * m.a13 + this.a12 * m.a23 + this.a13 * m.a33,
                          this.a21 * m.a11 + this.a22 * m.a21 + this.a23 * m.a31, this.a21 * m.a12 + this.a22 * m.a22 + this.a23 * m.a32, this.a21 * m.a13 + this.a22 * m.a23 + this.a23 * m.a33,
                          this.a31 * m.a11 + this.a32 * m.a21 + this.a33 * m.a31, this.a31 * m.a12 + this.a32 * m.a22 + this.a33 * m.a32, this.a31 * m.a13 + this.a32 * m.a23 + this.a33 * m.a33);
    }
}

