// Generated by Haxe 3.4.2
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class MaryTTSException : global::haxe.lang.HxObject {
		
		public MaryTTSException(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public MaryTTSException(string reason) {
			global::haxe.root.MaryTTSException.__hx_ctor__MaryTTSException(this, reason);
		}
		
		
		public static void __hx_ctor__MaryTTSException(global::haxe.root.MaryTTSException __hx_this, string reason) {
			__hx_this.reason = reason;
		}
		
		
		public string reason;
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 2090667972:
					{
						this.reason = global::haxe.lang.Runtime.toString(@value);
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
					case 2090667972:
					{
						return this.reason;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<object> baseArr) {
			baseArr.push("reason");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.root {
	public class MaryTTSBlendSequencer : global::haxe.lang.HxObject {
		
		static MaryTTSBlendSequencer() {
			global::haxe.root.MaryTTSBlendSequencer.RAMP_DOWN_PROPORTION = 1.5;
			global::haxe.root.MaryTTSBlendSequencer.DEFAULT_RAMP_UP_SPEED = 10.0;
			global::haxe.root.MaryTTSBlendSequencer.DEFAULT_RAMP_DOWN_SPEED = ( global::haxe.root.MaryTTSBlendSequencer.DEFAULT_RAMP_UP_SPEED * global::haxe.root.MaryTTSBlendSequencer.RAMP_DOWN_PROPORTION );
			global::haxe.root.MaryTTSBlendSequencer.RAMP_UP_DURATION_PROPORTION = 0.5;
			global::haxe.root.MaryTTSBlendSequencer.MIN_RAMP_SPEED = 2.0;
			global::haxe.root.MaryTTSBlendSequencer.MAX_RAMP_SPEED = 6.0;
			global::haxe.root.MaryTTSBlendSequencer.ANTICIPATION_SECS = 0.3;
			global::haxe.root.MaryTTSBlendSequencer.DEFAULT_VISEME_DURATION_SECS = 0.2;
			global::haxe.root.MaryTTSBlendSequencer.VISEMES = new global::haxe.root.Array<object>(new object[]{"phoneme_a_01", "phoneme_a_02", "phoneme_b_01", "phoneme_b_02", "phoneme_c_01", "phoneme_c_02", "phoneme_d_01", "phoneme_e_01", "phoneme_f_01", "phoneme_g_01", "phoneme_i_01", "phoneme_i_02", "phoneme_k_01", "phoneme_l_01", "phoneme_m_01", "phoneme_n_01", "phoneme_o_01", "phoneme_o_02", "phoneme_p_01", "phoneme_q_01", "phoneme_r_01", "phoneme_r_02", "phoneme_s_01", "phoneme_t_01", "phoneme_u_01", "phoneme_w_01", "phoneme_z_01"});
			object __temp_stmt2 = null;
			{
				global::haxe.ds.StringMap<object> _g = new global::haxe.ds.StringMap<object>();
				_g.@set("gi", "phoneme_g_01");
				_g.@set("ge", "phoneme_g_01");
				_g.@set("ji", "phoneme_g_01");
				_g.@set("c", "phoneme_g_01");
				_g.@set("il", "phoneme_l_01");
				_g.@set("el", "phoneme_l_01");
				_g.@set("di", "phoneme_d_01");
				_g.@set("eh", "phoneme_e_01");
				_g.@set("ie", "phoneme_i_01");
				_g.@set("ee", "phoneme_i_01");
				_g.@set("sh", "phoneme_g_01");
				_g.@set("sch", "phoneme_c_02");
				_g.@set("s", "phoneme_e_01");
				_g.@set("fv", "phoneme_f_01");
				_g.@set("fw", "phoneme_f_01");
				_g.@set("er", "phoneme_r_01");
				_g.@set("o", "phoneme_o_01");
				_g.@set("O", "phoneme_o_01");
				_g.@set("ov", "phoneme_o_01");
				_g.@set("oo", "phoneme_u_01");
				_g.@set("oh", "phoneme_u_01");
				_g.@set("mb", "phoneme_m_01");
				_g.@set("p", "phoneme_p_01");
				_g.@set("ah", "phoneme_a_01");
				_g.@set("a", "phoneme_a_01");
				_g.@set("{", "phoneme_e_01");
				_g.@set("@U", "phoneme_o_01");
				_g.@set("A", "phoneme_a_01");
				_g.@set("AI", "phoneme_a_01");
				_g.@set("aU", "phoneme_a_01");
				_g.@set("b", "phoneme_b_02");
				_g.@set("d", "phoneme_d_01");
				_g.@set("D", "phoneme_d_01");
				_g.@set("dZ", "phoneme_d_01");
				_g.@set("E", "phoneme_e_01");
				_g.@set("EI", "phoneme_i_01");
				_g.@set("i", "phoneme_i_01");
				_g.@set("I", "phoneme_i_01");
				_g.@set("m", "phoneme_m_01");
				_g.@set("f", "phoneme_f_01");
				_g.@set("l", "phoneme_l_01");
				_g.@set("r", "phoneme_r_01");
				_g.@set("r=", "phoneme_r_01");
				_g.@set("S", "phoneme_c_01");
				_g.@set("u", "phoneme_u_01");
				_g.@set("v", "phoneme_b_01");
				_g.@set("V", "phoneme_o_01");
				_g.@set("w", "phoneme_w_01");
				_g.@set("z", "phoneme_z_01");
				_g.@set("_", null);
				__temp_stmt2 = _g;
			}
			
			object __temp_stmt1 = global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (__temp_stmt2) ));
			global::haxe.root.MaryTTSBlendSequencer.PHONEMES_MAP = ((global::haxe.ds.StringMap<object>) (__temp_stmt1) );
			global::haxe.root.MaryTTSBlendSequencer.DEFAULT_VISEME = "phoneme_c_01";
		}
		
		
		public MaryTTSBlendSequencer(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public MaryTTSBlendSequencer() {
			global::haxe.root.MaryTTSBlendSequencer.__hx_ctor__MaryTTSBlendSequencer(this);
		}
		
		
		public static void __hx_ctor__MaryTTSBlendSequencer(global::haxe.root.MaryTTSBlendSequencer __hx_this) {
			__hx_this.ramp_down_speed = global::haxe.root.MaryTTSBlendSequencer.DEFAULT_RAMP_DOWN_SPEED;
			__hx_this.ramp_up_speed = global::haxe.root.MaryTTSBlendSequencer.DEFAULT_RAMP_UP_SPEED;
			__hx_this.active_viseme = null;
			__hx_this.ready_to_speak = false;
			__hx_this.position_tts = 0;
			__hx_this.speak_start_time = ((double) (((int) (-1) )) );
			__hx_this.last_time = ((double) (((int) (-1) )) );
			__hx_this.realized_visemes = null;
			__hx_this.realized_times = null;
		}
		
		
		public static double RAMP_DOWN_PROPORTION;
		
		public static double DEFAULT_RAMP_UP_SPEED;
		
		public static double DEFAULT_RAMP_DOWN_SPEED;
		
		public static double RAMP_UP_DURATION_PROPORTION;
		
		public static double MIN_RAMP_SPEED;
		
		public static double MAX_RAMP_SPEED;
		
		public static double ANTICIPATION_SECS;
		
		public static double DEFAULT_VISEME_DURATION_SECS;
		
		public static global::haxe.root.Array<object> VISEMES;
		
		public static int get_viseme_count() {
			return global::haxe.root.MaryTTSBlendSequencer.VISEMES.length;
		}
		
		
		public static global::haxe.ds.StringMap<object> PHONEMES_MAP;
		
		public static string DEFAULT_VISEME;
		
		public static void main() {
			global::haxe.root.MaryTTSBlendSequencer.local_test();
		}
		
		
		public static void local_test() {
			unchecked {
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "Consistency check...", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"local_test", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (386) )}));
				{
					object ph = ((object) (new global::haxe.ds._StringMap.StringMapKeyIterator<object>(((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (((global::haxe.IMap<object, object>) (global::haxe.root.MaryTTSBlendSequencer.PHONEMES_MAP) )) ))) ))) );
					while (global::haxe.lang.Runtime.toBool(global::haxe.lang.Runtime.callField(ph, "hasNext", 407283053, null))) {
						string ph1 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(ph, "next", 1224901875, null));
						string ms = global::haxe.lang.Runtime.toString((((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (((global::haxe.IMap<object, object>) (global::haxe.root.MaryTTSBlendSequencer.PHONEMES_MAP) )) ))) ).@get(ph1)).toDynamic());
						if ((  ! (string.Equals(ms, null))  && ( global::haxe.root.MaryTTSBlendSequencer.VISEMES.indexOf(ms, default(global::haxe.lang.Null<int>)) == -1 ) )) {
							throw global::haxe.lang.HaxeException.wrap(new global::haxe.root.MaryTTSException(((string) (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("For phoneme ", ph1), ", target mouth shape "), ms), " is not listed.")) )));
						}
						
					}
					
				}
				
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "Check done.", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"local_test", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (394) )}));
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "Instance...", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"local_test", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (396) )}));
				global::haxe.root.MaryTTSBlendSequencer seq = new global::haxe.root.MaryTTSBlendSequencer();
				global::haxe.Log.trace.__hx_invoke2_o(default(double), seq, default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"local_test", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (399) )}));
				seq.stop_sequencer();
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "Reading durations", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"local_test", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (403) )}));
				string durations = global::sys.io.File.getContent("data/realized_duration.txt");
				seq.parse_realized_durations(durations);
				int n_visemes = global::haxe.root.MaryTTSBlendSequencer.get_viseme_count();
				double[] this1 = new double[n_visemes];
				double[] visemes_buffer = ((double[]) (this1) );
				{
					int _g1 = 0;
					int _g = ( ((double[]) (visemes_buffer) ) as global::System.Array ).Length;
					while (( _g1 < _g )) {
						int i = _g1++;
						((double[]) (visemes_buffer) )[i] = 0.0;
					}
					
				}
				
				double simulated_time = ((double) (0) );
				{
					int _g2 = 0;
					while (( _g2 < 100 )) {
						int i1 = _g2++;
						seq.update(simulated_time, visemes_buffer);
						simulated_time += 0.05;
					}
					
				}
				
				global::haxe.Log.trace.__hx_invoke2_o(default(double), "Main finished.", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"local_test", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (423) )}));
			}
		}
		
		
		public static void test_speed() {
			unchecked {
				int NUM_ITER = 100000;
				double SIM_TIME = 4.0;
				global::haxe.root.MaryTTSBlendSequencer seq = new global::haxe.root.MaryTTSBlendSequencer();
				int n_visemes = global::haxe.root.MaryTTSBlendSequencer.get_viseme_count();
				double[] this1 = new double[n_visemes];
				double[] visemes_buffer = ((double[]) (this1) );
				{
					int _g1 = 0;
					int _g = ( ((double[]) (visemes_buffer) ) as global::System.Array ).Length;
					while (( _g1 < _g )) {
						int i = _g1++;
						((double[]) (visemes_buffer) )[i] = 0.0;
					}
					
				}
				
				string durations = global::sys.io.File.getContent("data/realized_duration.txt");
				seq.parse_realized_durations(durations);
				int iterations = 0;
				double before = global::haxe.root.Sys.time();
				{
					int _g11 = 0;
					int _g2 = NUM_ITER;
					while (( _g11 < _g2 )) {
						int s = _g11++;
						double simulated_time = ((double) (0) );
						seq.reset_timers();
						while (( simulated_time < SIM_TIME )) {
							seq.update(simulated_time, visemes_buffer);
							simulated_time += 0.05;
							 ++ iterations;
						}
						
					}
					
				}
				
				double after = global::haxe.root.Sys.time();
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Simulated ", global::haxe.lang.Runtime.toString(NUM_ITER)), " sessions of "), global::haxe.lang.Runtime.toString(SIM_TIME)), " seconds"), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"test_speed", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (463) )}));
				double elapsed = ( after - before );
				double iter_per_sec = ( iterations / elapsed );
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("Number of iterations: ", global::haxe.lang.Runtime.toString(iterations)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"test_speed", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (466) )}));
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("Elapsed (secs): ", global::haxe.lang.Runtime.toString(elapsed)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"test_speed", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (467) )}));
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("Iter / sec: ", global::haxe.lang.Runtime.toString(iter_per_sec)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"test_speed", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (468) )}));
			}
		}
		
		
		public global::haxe.root.Array<double> realized_times;
		
		public global::haxe.root.Array<object> realized_visemes;
		
		public double last_time;
		
		public double speak_start_time;
		
		public int position_tts;
		
		public bool ready_to_speak;
		
		public string active_viseme;
		
		public double ramp_up_speed;
		
		public double ramp_down_speed;
		
		public virtual void stop_sequencer() {
			this.ready_to_speak = false;
		}
		
		
		public virtual bool is_speaking() {
			return ( this.ready_to_speak == true );
		}
		
		
		public virtual void parse_realized_durations(string realized_durations) {
			unchecked {
				this.realized_times = new global::haxe.root.Array<double>();
				this.realized_visemes = new global::haxe.root.Array<object>();
				global::haxe.root.Array<object> parsed_durations = new global::haxe.root.Array<object>();
				global::haxe.root.Array<object> parsed_phonemes = new global::haxe.root.Array<object>();
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = global::haxe.lang.StringExt.split(realized_durations, "\n");
					while (( _g < _g1.length )) {
						string line = global::haxe.lang.Runtime.toString(_g1[_g]);
						 ++ _g;
						if (( line.Length == 0 )) {
							continue;
						}
						
						if (string.Equals(global::haxe.lang.StringExt.charAt(line, 0), "#")) {
							continue;
						}
						
						global::haxe.root.Array<object> split_line = global::haxe.lang.StringExt.split(line, " ");
						if (( split_line.length != 3 )) {
							throw global::haxe.lang.HaxeException.wrap(new global::haxe.root.MaryTTSException(((string) (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Expected 3 data per line. Found ", global::haxe.lang.Runtime.toString(split_line.length)), ". Line: \'"), line), "\'")) )));
						}
						
						parsed_durations.push(global::haxe.lang.Runtime.toString(split_line[0]));
						parsed_phonemes.push(global::haxe.lang.Runtime.toString(split_line[2]));
					}
					
				}
				
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("PARSED (", global::haxe.lang.Runtime.toString(parsed_durations.length)), ") phonemes."), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"parse_realized_durations", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (203) )}));
				int i = 0;
				{
					int _g2 = 0;
					while (( _g2 < parsed_phonemes.length )) {
						string p = global::haxe.lang.Runtime.toString(parsed_phonemes[_g2]);
						 ++ _g2;
						double dur = global::haxe.root.Std.parseFloat(global::haxe.lang.Runtime.toString(parsed_durations[i]));
						string shape = null;
						if (((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (((global::haxe.IMap<object, object>) (global::haxe.root.MaryTTSBlendSequencer.PHONEMES_MAP) )) ))) ).exists(p)) {
							shape = global::haxe.lang.Runtime.toString((((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (((global::haxe.IMap<object, object>) (global::haxe.root.MaryTTSBlendSequencer.PHONEMES_MAP) )) ))) ).@get(p)).toDynamic());
						}
						else {
							shape = global::haxe.root.MaryTTSBlendSequencer.DEFAULT_VISEME;
						}
						
						global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Mapping \'", p), "\' --> \'"), shape), "\' at "), global::haxe.lang.Runtime.toString(dur)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"parse_realized_durations", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (220) )}));
						this.realized_times.push(dur);
						this.realized_visemes.push(shape);
						 ++ i;
					}
					
				}
				
				this.ready_to_speak = true;
				global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("MAPPED (", global::haxe.lang.Runtime.toString(this.realized_visemes.length)), "):"), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"parse_realized_durations", "MaryTTSBlendSequencer", "MaryTTSBlendSequencer.hx"}, new int[]{1981972957}, new double[]{((double) (230) )}));
			}
		}
		
		
		public virtual void reset_timers() {
			unchecked {
				this.last_time = ((double) (-1) );
				this.speak_start_time = ((double) (-1) );
				this.position_tts = 0;
				this.ready_to_speak = true;
				this.active_viseme = null;
			}
		}
		
		
		public virtual void update(double now, double[] viseme_weights) {
			unchecked {
				if (( ( ((double[]) (viseme_weights) ) as global::System.Array ).Length != global::haxe.root.MaryTTSBlendSequencer.VISEMES.length )) {
					throw global::haxe.lang.HaxeException.wrap(new global::haxe.root.MaryTTSException(((string) (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Viseme weight vector has wrong size.", " Expected "), global::haxe.lang.Runtime.toString(global::haxe.root.MaryTTSBlendSequencer.VISEMES.length)), ", found "), global::haxe.lang.Runtime.toString(( ((double[]) (viseme_weights) ) as global::System.Array ).Length))) )));
				}
				
				if (( this.ready_to_speak == false )) {
					return;
				}
				
				if (( this.last_time == -1 )) {
					this.last_time = now;
					this.speak_start_time = now;
					this.position_tts = 0;
					return;
				}
				
				double elapsed_time = ( now - this.speak_start_time );
				double delta_time = ( now - this.last_time );
				this.last_time = now;
				elapsed_time += global::haxe.root.MaryTTSBlendSequencer.ANTICIPATION_SECS;
				int phonemes_count = this.realized_visemes.length;
				if (( this.position_tts < phonemes_count )) {
					double time_to_wait = this.realized_times[this.position_tts];
					if (( elapsed_time >= time_to_wait )) {
						this.active_viseme = global::haxe.lang.Runtime.toString(this.realized_visemes[this.position_tts]);
						this.position_tts += 1;
						double viseme_duration = global::haxe.root.MaryTTSBlendSequencer.DEFAULT_VISEME_DURATION_SECS;
						if (( this.position_tts < phonemes_count )) {
							double next_time_to_wait = this.realized_times[this.position_tts];
							viseme_duration = ( next_time_to_wait - time_to_wait );
						}
						
						double ramp_up_duration = ( viseme_duration * global::haxe.root.MaryTTSBlendSequencer.RAMP_UP_DURATION_PROPORTION );
						this.ramp_up_speed = ( 1 / ramp_up_duration );
						this.ramp_up_speed = ( (( this.ramp_up_speed < global::haxe.root.MaryTTSBlendSequencer.MIN_RAMP_SPEED )) ? (global::haxe.root.MaryTTSBlendSequencer.MIN_RAMP_SPEED) : (( (( this.ramp_up_speed > global::haxe.root.MaryTTSBlendSequencer.MAX_RAMP_SPEED )) ? (global::haxe.root.MaryTTSBlendSequencer.MAX_RAMP_SPEED) : (this.ramp_up_speed) )) );
						this.ramp_down_speed = ( this.ramp_up_speed * global::haxe.root.MaryTTSBlendSequencer.RAMP_DOWN_PROPORTION );
					}
					
				}
				else {
					this.active_viseme = null;
					double last_time_to_wait = ((double) (0) );
					if (( this.realized_times.length > 0 )) {
						last_time_to_wait = this.realized_times[( this.realized_times.length - 1 )];
					}
					
					if (( elapsed_time > ( last_time_to_wait + 1.0 ) )) {
						this.ready_to_speak = false;
					}
					
				}
				
				{
					int _g1 = 0;
					int _g = global::haxe.root.MaryTTSBlendSequencer.VISEMES.length;
					while (( _g1 < _g )) {
						int i = _g1++;
						string viseme = global::haxe.lang.Runtime.toString(global::haxe.root.MaryTTSBlendSequencer.VISEMES[i]);
						double current_weight = ((double) (((double[]) (viseme_weights) )[i]) );
						if (string.Equals(viseme, this.active_viseme)) {
							double inc = ( this.ramp_up_speed * delta_time );
							current_weight += inc;
							if (( current_weight > 1.0 )) {
								current_weight = 1.0;
							}
							
						}
						else {
							double dec = (  - (this.ramp_down_speed)  * delta_time );
							current_weight += dec;
							if (( current_weight < 0.0 )) {
								current_weight = 0.0;
							}
							
						}
						
						((double[]) (viseme_weights) )[i] = current_weight;
					}
					
				}
				
			}
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1790523959:
					{
						this.ramp_down_speed = ((double) (@value) );
						return @value;
					}
					
					
					case 316767152:
					{
						this.ramp_up_speed = ((double) (@value) );
						return @value;
					}
					
					
					case 2057722141:
					{
						this.position_tts = ((int) (@value) );
						return @value;
					}
					
					
					case 999145111:
					{
						this.speak_start_time = ((double) (@value) );
						return @value;
					}
					
					
					case 965584342:
					{
						this.last_time = ((double) (@value) );
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
					case 1790523959:
					{
						this.ramp_down_speed = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 316767152:
					{
						this.ramp_up_speed = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1215249846:
					{
						this.active_viseme = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 290374058:
					{
						this.ready_to_speak = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 2057722141:
					{
						this.position_tts = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 999145111:
					{
						this.speak_start_time = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 965584342:
					{
						this.last_time = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 722177317:
					{
						this.realized_visemes = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1048318581:
					{
						this.realized_times = ((global::haxe.root.Array<double>) (global::haxe.root.Array<object>.__hx_cast<double>(((global::haxe.root.Array) (@value) ))) );
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
					case 117802505:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "update", 117802505)) );
					}
					
					
					case 836123838:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "reset_timers", 836123838)) );
					}
					
					
					case 1040314522:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "parse_realized_durations", 1040314522)) );
					}
					
					
					case 1782881861:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "is_speaking", 1782881861)) );
					}
					
					
					case 882154836:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "stop_sequencer", 882154836)) );
					}
					
					
					case 1790523959:
					{
						return this.ramp_down_speed;
					}
					
					
					case 316767152:
					{
						return this.ramp_up_speed;
					}
					
					
					case 1215249846:
					{
						return this.active_viseme;
					}
					
					
					case 290374058:
					{
						return this.ready_to_speak;
					}
					
					
					case 2057722141:
					{
						return this.position_tts;
					}
					
					
					case 999145111:
					{
						return this.speak_start_time;
					}
					
					
					case 965584342:
					{
						return this.last_time;
					}
					
					
					case 722177317:
					{
						return this.realized_visemes;
					}
					
					
					case 1048318581:
					{
						return this.realized_times;
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
					case 1790523959:
					{
						return this.ramp_down_speed;
					}
					
					
					case 316767152:
					{
						return this.ramp_up_speed;
					}
					
					
					case 2057722141:
					{
						return ((double) (this.position_tts) );
					}
					
					
					case 999145111:
					{
						return this.speak_start_time;
					}
					
					
					case 965584342:
					{
						return this.last_time;
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
					case 117802505:
					{
						this.update(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double[]) (dynargs[1]) ));
						break;
					}
					
					
					case 836123838:
					{
						this.reset_timers();
						break;
					}
					
					
					case 1040314522:
					{
						this.parse_realized_durations(global::haxe.lang.Runtime.toString(dynargs[0]));
						break;
					}
					
					
					case 1782881861:
					{
						return this.is_speaking();
					}
					
					
					case 882154836:
					{
						this.stop_sequencer();
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return null;
			}
		}
		
		
		public override void __hx_getFields(global::haxe.root.Array<object> baseArr) {
			baseArr.push("ramp_down_speed");
			baseArr.push("ramp_up_speed");
			baseArr.push("active_viseme");
			baseArr.push("ready_to_speak");
			baseArr.push("position_tts");
			baseArr.push("speak_start_time");
			baseArr.push("last_time");
			baseArr.push("realized_visemes");
			baseArr.push("realized_times");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


