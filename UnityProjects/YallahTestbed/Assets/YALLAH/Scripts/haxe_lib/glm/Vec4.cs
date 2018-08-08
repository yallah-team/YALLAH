// Generated by Haxe 3.4.2
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace glm {
	public class Vec4 : global::haxe.lang.HxObject {
		
		public Vec4(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Vec4(global::haxe.lang.Null<double> x, global::haxe.lang.Null<double> y, global::haxe.lang.Null<double> z, global::haxe.lang.Null<double> w) {
			global::glm.Vec4.__hx_ctor_glm_Vec4(this, x, y, z, w);
		}
		
		
		public static void __hx_ctor_glm_Vec4(global::glm.Vec4 __hx_this, global::haxe.lang.Null<double> x, global::haxe.lang.Null<double> y, global::haxe.lang.Null<double> z, global::haxe.lang.Null<double> w) {
			double __temp_w58 = ( ( ! (w.hasValue) ) ? (((double) (0) )) : ((w).@value) );
			double __temp_z57 = ( ( ! (z.hasValue) ) ? (((double) (0) )) : ((z).@value) );
			double __temp_y56 = ( ( ! (y.hasValue) ) ? (((double) (0) )) : ((y).@value) );
			double __temp_x55 = ( ( ! (x.hasValue) ) ? (((double) (0) )) : ((x).@value) );
			__hx_this.x = __temp_x55;
			__hx_this.y = __temp_y56;
			__hx_this.z = __temp_z57;
			__hx_this.w = __temp_w58;
		}
		
		
		public static global::glm.Vec4 copy(global::glm.Vec4 src, global::glm.Vec4 dest) {
			dest.x = src.x;
			dest.y = src.y;
			dest.z = src.z;
			dest.w = src.w;
			return dest;
		}
		
		
		public static global::glm.Vec4 @set(global::glm.Vec4 dest, global::haxe.lang.Null<double> x, global::haxe.lang.Null<double> y, global::haxe.lang.Null<double> z, global::haxe.lang.Null<double> w) {
			double __temp_w54 = ( ( ! (w.hasValue) ) ? (((double) (0) )) : ((w).@value) );
			double __temp_z53 = ( ( ! (z.hasValue) ) ? (((double) (0) )) : ((z).@value) );
			double __temp_y52 = ( ( ! (y.hasValue) ) ? (((double) (0) )) : ((y).@value) );
			double __temp_x51 = ( ( ! (x.hasValue) ) ? (((double) (0) )) : ((x).@value) );
			dest.x = __temp_x51;
			dest.y = __temp_y52;
			dest.z = __temp_z53;
			dest.w = __temp_w54;
			return dest;
		}
		
		
		public static global::glm.Vec4 addVec(global::glm.Vec4 a, global::glm.Vec4 b, global::glm.Vec4 dest) {
			dest.x = ( a.x + b.x );
			dest.y = ( a.y + b.y );
			dest.z = ( a.z + b.z );
			dest.w = ( a.w + b.w );
			return dest;
		}
		
		
		public static global::glm.Vec4 subtractVec(global::glm.Vec4 a, global::glm.Vec4 b, global::glm.Vec4 dest) {
			dest.x = ( a.x - b.x );
			dest.y = ( a.y - b.y );
			dest.z = ( a.z - b.z );
			dest.w = ( a.w - b.w );
			return dest;
		}
		
		
		public static global::glm.Vec4 addVecOp(global::glm.Vec4 a, global::glm.Vec4 b) {
			global::glm.Vec4 dest = new global::glm.Vec4(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
			dest.x = ( a.x + b.x );
			dest.y = ( a.y + b.y );
			dest.z = ( a.z + b.z );
			dest.w = ( a.w + b.w );
			return dest;
		}
		
		
		public static global::glm.Vec4 subtractVecOp(global::glm.Vec4 a, global::glm.Vec4 b) {
			global::glm.Vec4 dest = new global::glm.Vec4(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
			dest.x = ( a.x - b.x );
			dest.y = ( a.y - b.y );
			dest.z = ( a.z - b.z );
			dest.w = ( a.w - b.w );
			return dest;
		}
		
		
		public static global::glm.Vec4 addScalar(global::glm.Vec4 a, double s, global::glm.Vec4 dest) {
			dest.x = ( a.x + s );
			dest.y = ( a.y + s );
			dest.z = ( a.z + s );
			dest.w = ( a.w + s );
			return dest;
		}
		
		
		public static global::glm.Vec4 multiplyScalar(global::glm.Vec4 a, double s, global::glm.Vec4 dest) {
			dest.x = ( a.x * s );
			dest.y = ( a.y * s );
			dest.z = ( a.z * s );
			dest.w = ( a.w * s );
			return dest;
		}
		
		
		public static global::glm.Vec4 addScalarOp(global::glm.Vec4 a, double s) {
			global::glm.Vec4 dest = new global::glm.Vec4(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
			dest.x = ( a.x + s );
			dest.y = ( a.y + s );
			dest.z = ( a.z + s );
			dest.w = ( a.w + s );
			return dest;
		}
		
		
		public static global::glm.Vec4 subtractScalarOp(global::glm.Vec4 a, double s) {
			double s1 =  - (s) ;
			global::glm.Vec4 dest = new global::glm.Vec4(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
			dest.x = ( a.x + s1 );
			dest.y = ( a.y + s1 );
			dest.z = ( a.z + s1 );
			dest.w = ( a.w + s1 );
			return dest;
		}
		
		
		public static global::glm.Vec4 multiplyScalarOp(global::glm.Vec4 a, double s) {
			global::glm.Vec4 dest = new global::glm.Vec4(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
			dest.x = ( a.x * s );
			dest.y = ( a.y * s );
			dest.z = ( a.z * s );
			dest.w = ( a.w * s );
			return dest;
		}
		
		
		public static global::glm.Vec4 divideScalarOp(global::glm.Vec4 a, double s) {
			unchecked {
				double s1 = ( 1 / s );
				global::glm.Vec4 dest = new global::glm.Vec4(default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>), default(global::haxe.lang.Null<double>));
				dest.x = ( a.x * s1 );
				dest.y = ( a.y * s1 );
				dest.z = ( a.z * s1 );
				dest.w = ( a.w * s1 );
				return dest;
			}
		}
		
		
		public static double distanceSquared(global::glm.Vec4 a, global::glm.Vec4 b) {
			return ( ( ( ( (( a.x - b.x )) * (( a.x - b.x )) ) + ( (( a.y - b.y )) * (( a.y - b.y )) ) ) + ( (( a.z - b.z )) * (( a.z - b.z )) ) ) + ( (( a.w - b.w )) * (( a.w - b.w )) ) );
		}
		
		
		public static double distance(global::glm.Vec4 a, global::glm.Vec4 b) {
			return global::System.Math.Sqrt(((double) (( ( ( ( (( a.x - b.x )) * (( a.x - b.x )) ) + ( (( a.y - b.y )) * (( a.y - b.y )) ) ) + ( (( a.z - b.z )) * (( a.z - b.z )) ) ) + ( (( a.w - b.w )) * (( a.w - b.w )) ) )) ));
		}
		
		
		public static double dot(global::glm.Vec4 a, global::glm.Vec4 b) {
			return ( ( ( ( a.x * b.x ) + ( a.y * b.y ) ) + ( a.z * b.z ) ) + ( a.w * b.w ) );
		}
		
		
		public static global::glm.Vec4 normalize(global::glm.Vec4 v, global::glm.Vec4 dest) {
			unchecked {
				double length = global::System.Math.Sqrt(((double) (( ( ( ( v.x * v.x ) + ( v.y * v.y ) ) + ( v.z * v.z ) ) + ( v.w * v.w ) )) ));
				double mult = ((double) (0) );
				if (( length >= global::glm.GLM.EPSILON )) {
					mult = ( 1 / length );
				}
				
				dest.x = ( v.x * mult );
				dest.y = ( v.y * mult );
				dest.z = ( v.z * mult );
				dest.w = ( v.w * mult );
				return dest;
			}
		}
		
		
		public static global::glm.Vec4 lerp(global::glm.Vec4 a, global::glm.Vec4 b, double t, global::glm.Vec4 dest) {
			double a1 = a.x;
			dest.x = ( a1 + ( t * (( b.x - a1 )) ) );
			double a2 = a.y;
			dest.y = ( a2 + ( t * (( b.y - a2 )) ) );
			double a3 = a.z;
			dest.z = ( a3 + ( t * (( b.z - a3 )) ) );
			double a4 = a.w;
			dest.w = ( a4 + ( t * (( b.w - a4 )) ) );
			return dest;
		}
		
		
		public static global::glm.Vec4 fromFloatArray(global::haxe.root.Array<double> arr) {
			unchecked {
				return new global::glm.Vec4(new global::haxe.lang.Null<double>(arr[0], true), new global::haxe.lang.Null<double>(arr[1], true), new global::haxe.lang.Null<double>(arr[2], true), new global::haxe.lang.Null<double>(arr[3], true));
			}
		}
		
		
		public double x;
		
		public double y;
		
		public double z;
		
		public double w;
		
		
		
		public double get_r() {
			return this.x;
		}
		
		
		public double set_r(double v) {
			return this.x = v;
		}
		
		
		
		
		public double get_g() {
			return this.y;
		}
		
		
		public double set_g(double v) {
			return this.y = v;
		}
		
		
		
		
		public double get_b() {
			return this.z;
		}
		
		
		public double set_b(double v) {
			return this.z = v;
		}
		
		
		
		
		public double get_a() {
			return this.w;
		}
		
		
		public double set_a(double v) {
			return this.w = v;
		}
		
		
		public double @get(int key) {
			unchecked {
				switch (key) {
					case 0:
					{
						return this.x;
					}
					
					
					case 1:
					{
						return this.y;
					}
					
					
					case 2:
					{
						return this.z;
					}
					
					
					case 3:
					{
						return this.w;
					}
					
					
					default:
					{
						throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Index ", global::haxe.lang.Runtime.toString(key)), " out of bounds (0-3)!"));
					}
					
				}
				
			}
		}
		
		
		public double arrayWrite(int key, double @value) {
			unchecked {
				switch (key) {
					case 0:
					{
						return this.x = @value;
					}
					
					
					case 1:
					{
						return this.y = @value;
					}
					
					
					case 2:
					{
						return this.z = @value;
					}
					
					
					case 3:
					{
						return this.w = @value;
					}
					
					
					default:
					{
						throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Index ", global::haxe.lang.Runtime.toString(key)), " out of bounds (0-3)!"));
					}
					
				}
				
			}
		}
		
		
		public bool @equals(global::glm.Vec4 b) {
			return  ! ((( ( ( ( global::System.Math.Abs(((double) (( this.x - b.x )) )) >= global::glm.GLM.EPSILON ) || ( global::System.Math.Abs(((double) (( this.y - b.y )) )) >= global::glm.GLM.EPSILON ) ) || ( global::System.Math.Abs(((double) (( this.z - b.z )) )) >= global::glm.GLM.EPSILON ) ) || ( global::System.Math.Abs(((double) (( this.w - b.w )) )) >= global::glm.GLM.EPSILON ) ))) ;
		}
		
		
		public string toString() {
			return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("<", global::haxe.lang.Runtime.toString(this.x)), ", "), global::haxe.lang.Runtime.toString(this.y)), ", "), global::haxe.lang.Runtime.toString(this.z)), ", "), global::haxe.lang.Runtime.toString(this.w)), ">");
		}
		
		
		public double lengthSquared() {
			return ( ( ( ( this.x * this.x ) + ( this.y * this.y ) ) + ( this.z * this.z ) ) + ( this.w * this.w ) );
		}
		
		
		public double length() {
			return global::System.Math.Sqrt(((double) (( ( ( ( this.x * this.x ) + ( this.y * this.y ) ) + ( this.z * this.z ) ) + ( this.w * this.w ) )) ));
		}
		
		
		public global::haxe.root.Array<double> toFloatArray() {
			return new global::haxe.root.Array<double>(new double[]{this.x, this.y, this.z, this.w});
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 97:
					{
						this.set_a(@value);
						return @value;
					}
					
					
					case 98:
					{
						this.set_b(@value);
						return @value;
					}
					
					
					case 103:
					{
						this.set_g(@value);
						return @value;
					}
					
					
					case 114:
					{
						this.set_r(@value);
						return @value;
					}
					
					
					case 119:
					{
						this.w = ((double) (@value) );
						return @value;
					}
					
					
					case 122:
					{
						this.z = ((double) (@value) );
						return @value;
					}
					
					
					case 121:
					{
						this.y = ((double) (@value) );
						return @value;
					}
					
					
					case 120:
					{
						this.x = ((double) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 97:
					{
						this.set_a(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 98:
					{
						this.set_b(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 103:
					{
						this.set_g(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 114:
					{
						this.set_r(((double) (global::haxe.lang.Runtime.toDouble(@value)) ));
						return @value;
					}
					
					
					case 119:
					{
						this.w = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 122:
					{
						this.z = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 121:
					{
						this.y = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 120:
					{
						this.x = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1711764408:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toFloatArray", 1711764408)) );
					}
					
					
					case 520590566:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "length", 520590566)) );
					}
					
					
					case 893723873:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "lengthSquared", 893723873)) );
					}
					
					
					case 946786476:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 1072885311:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "equals", 1072885311)) );
					}
					
					
					case 1250329734:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "arrayWrite", 1250329734)) );
					}
					
					
					case 5144726:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get", 5144726)) );
					}
					
					
					case 2049940292:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_a", 2049940292)) );
					}
					
					
					case 291546424:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_a", 291546424)) );
					}
					
					
					case 97:
					{
						return this.get_a();
					}
					
					
					case 2049940293:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_b", 2049940293)) );
					}
					
					
					case 291546425:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_b", 291546425)) );
					}
					
					
					case 98:
					{
						return this.get_b();
					}
					
					
					case 2049940298:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_g", 2049940298)) );
					}
					
					
					case 291546430:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_g", 291546430)) );
					}
					
					
					case 103:
					{
						return this.get_g();
					}
					
					
					case 2049940309:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set_r", 2049940309)) );
					}
					
					
					case 291546441:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get_r", 291546441)) );
					}
					
					
					case 114:
					{
						return this.get_r();
					}
					
					
					case 119:
					{
						return this.w;
					}
					
					
					case 122:
					{
						return this.z;
					}
					
					
					case 121:
					{
						return this.y;
					}
					
					
					case 120:
					{
						return this.x;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 97:
					{
						return this.get_a();
					}
					
					
					case 98:
					{
						return this.get_b();
					}
					
					
					case 103:
					{
						return this.get_g();
					}
					
					
					case 114:
					{
						return this.get_r();
					}
					
					
					case 119:
					{
						return this.w;
					}
					
					
					case 122:
					{
						return this.z;
					}
					
					
					case 121:
					{
						return this.y;
					}
					
					
					case 120:
					{
						return this.x;
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs) {
			unchecked {
				switch (hash) {
					case 1711764408:
					{
						return this.toFloatArray();
					}
					
					
					case 520590566:
					{
						return this.length();
					}
					
					
					case 893723873:
					{
						return this.lengthSquared();
					}
					
					
					case 946786476:
					{
						return this.toString();
					}
					
					
					case 1072885311:
					{
						return this.@equals(((global::glm.Vec4) (dynargs[0]) ));
					}
					
					
					case 1250329734:
					{
						return this.arrayWrite(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ));
					}
					
					
					case 5144726:
					{
						return this.@get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 2049940292:
					{
						return this.set_a(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 291546424:
					{
						return this.get_a();
					}
					
					
					case 2049940293:
					{
						return this.set_b(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 291546425:
					{
						return this.get_b();
					}
					
					
					case 2049940298:
					{
						return this.set_g(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 291546430:
					{
						return this.get_g();
					}
					
					
					case 2049940309:
					{
						return this.set_r(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
					}
					
					
					case 291546441:
					{
						return this.get_r();
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<object> baseArr) {
			baseArr.push("a");
			baseArr.push("b");
			baseArr.push("g");
			baseArr.push("r");
			baseArr.push("w");
			baseArr.push("z");
			baseArr.push("y");
			baseArr.push("x");
			base.__hx_getFields(baseArr);
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}


